using System;
using System.Collections.Generic;
namespace UltraEnterpriseSDLC
{
    public enum RiskLevel
    {
        Low,Medium,High,Critical
    }
    public enum SDLCStage
    {
        Backlog=0,Requirement=1,Design=2,Development=2,CodeReview=1,Testing=1,UAT=0,Deployment=3,Maintenance=0
    }
    public class Requirement
    {
        public int Id{get;}
        public string Title{get;}
        public RiskLevel Risk{get;}
        public Requirement(int id,string title,RiskLevel risk)
        {
            Id=id;
            Title=title;
            Risk=risk;
        }
    }
    public sealed class WorkItem
{
    public int Id { get; }
    public string Name { get; }
    public SDLCStage Stage { get; set; }
    public HashSet<int> DependencyIds { get; }

    public WorkItem(int id, string name, SDLCStage stage)
    {
        Id = id;
        Name = name;
        Stage = stage;
        DependencyIds = new HashSet<int>();
    }
}
    public sealed class BuildSnapshot
    {
        public string Version{get;}
        public DateTime Timestamp{get;}
        public BuildSnapshot(string version)
        {
            Version=version;
            Timestamp=DateTime.Now;
        }
    }
    public sealed class AuditLog
    {
        public DateTime Time{get;}
        public string Action{get;}
        public AuditLog(string action)
        {
            Time=DateTime.Now;
            Action=action;
        }
    }
    public sealed class QualityMetric
    {
        public string Name{get;}
        public double Score{get;}
        public QualityMetric(string name,double score)
        {
            Name=name;
            Score=score;
        }
    }
    public class EnterpriseSDLCEngine
    {
        private List<Requirement> _requirements;
        private Dictionary<int, WorkItem> _workItemRegistry;
        private SortedDictionary<SDLCStage, List<WorkItem>> _stageBoard;
        private Queue<WorkItem> _executionQueue;
        private Stack<BuildSnapshot> _rollbackStack;
        private HashSet<string> _uniqueTestSuites;
        private LinkedList<AuditLog> _auditLedger;
        private SortedList<double, QualityMetric> _releaseScoreboard;
        private int _requirementCounter;
        private int _workItemCounter;

        public EnterpriseSDLCEngine()
        {
            _requirements=new List<Requirement>();
            _workItemRegistry=new Dictionary<int, WorkItem>();
            _stageBoard=new SortedDictionary<SDLCStage, List<WorkItem>>();
            foreach(SDLCStage stage in Enum.GetValues(typeof(SDLCStage)))
            {
                _stageBoard[stage]=new List<WorkItem>();
            }
            _executionQueue=new Queue<WorkItem>();
            _rollbackStack=new Stack<BuildSnapshot>(); 
            _uniqueTestSuites=new HashSet<string>();
            _auditLedger=new LinkedList<AuditLog>();
            _releaseScoreboard=new SortedList<double, QualityMetric>();
        }
        public void AddRequirement(string title,RiskLevel risk)
        {
            Requirement req=new Requirement(_requirementCounter,title,risk);
            _requirementCounter++;
            _requirementCounter.Add(req);
            _auditLedger.AddLast(new AuditLog($"Requirement added: {title}, Risk: {risk}"));
        }
         public WorkItem CreateWorkItem(string name, SDLCStage stage)
        {
            WorkItem item = new WorkItem(_workItemCounter, name, stage);
            _workItemCounter++;

            _workItemRegistry[item.Id] = item;
            _stageBoard[stage].Add(item);

            _auditLedger.AddLast(
                new AuditLog($"WorkItem created: {name}, Stage: {stage}")
            );

            return item;
        }

        public void AddDependency(int workItemId, int dependsOnId)
        {
            if (_workItemRegistry.ContainsKey(workItemId) &&
                _workItemRegistry.ContainsKey(dependsOnId))
            {
                _workItemRegistry[workItemId].DependencyIds.Add(dependsOnId);
                _auditLedger.AddLast(
                    new AuditLog($"Dependency added: WorkItem {workItemId} depends on {dependsOnId}")
                );
            }
        }

        public void PlanStage(SDLCStage stage)
        {
            foreach (WorkItem item in _stageBoard[stage])
            {
                bool eligible = true;

                foreach (int depId in item.DependencyIds)
                {
                    if (_workItemRegistry.ContainsKey(depId))
                    {
                        if (_workItemRegistry[depId].Stage <= stage)
                        {
                            eligible = false;
                            break;
                        }
                    }
                }

                if (eligible)
                {
                    _executionQueue.Enqueue(item);
                }
            }

            _auditLedger.AddLast(new AuditLog($"Stage planned: {stage}"));
        }

        public void ExecuteNext()
        {
            if (_executionQueue.Count == 0)
                return;

            WorkItem item = _executionQueue.Dequeue();
            SDLCStage previousStage = item.Stage;

            if (item.Stage < SDLCStage.Maintenance)
            {
                _stageBoard[item.Stage].Remove(item);
                item.Stage++;
                _stageBoard[item.Stage].Add(item);
            }

            _auditLedger.AddLast(
                new AuditLog($"Executed WorkItem {item.Id}: {previousStage} → {item.Stage}")
            );
        }

        public void RegisterTestSuite(string suiteId)
        {
            _uniqueTestSuites.Add(suiteId);
            _auditLedger.AddLast(new AuditLog($"Test suite registered: {suiteId}"));
        }

        public void DeployRelease(string version)
        {
            BuildSnapshot snapshot = new BuildSnapshot(version);
            _rollbackStack.Push(snapshot);
            _auditLedger.AddLast(new AuditLog($"Release deployed: {version}"));
        }

        public void RollbackRelease()
        {
            if (_rollbackStack.Count == 0)
                return;

            BuildSnapshot snapshot = _rollbackStack.Pop();
            _auditLedger.AddLast(new AuditLog($"Rollback executed: {snapshot.Version}"));
        }

        public void RecordQualityMetric(string metricName, double score)
        {
            if (!_releaseScoreboard.ContainsKey(score))
            {
                QualityMetric metric = new QualityMetric(metricName, score);
                _releaseScoreboard.Add(score, metric);
            }
        }

        public void PrintAuditLedger()
        {
            foreach (AuditLog log in _auditLedger)
            {
                Console.WriteLine($"{log.Time}: {log.Action}");
            }
        }
    }
}