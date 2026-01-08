<<<<<<< HEAD
﻿// using System;
// delegate void PaymentDeletgate(decimal amount);
// class PaymentService
// {
//     public void ProcessPayment(decimal amount)
//     {
//         Console.WriteLine("Payment of "+amount+ " processed successfully.");
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         PaymentServise servise=new PaymentServise();
//         PaymentDeletgate payment=servise.ProcessPayment;
//         payment(5000);
//     }
// }

////###############################################################################################

// static class PaymentExtensions
// {
//     public static bool IsValidPayment(this decimal amount)
//     {
//         return amount>0 && amount <= 1_000_000;
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         PaymentService service=new PaymentService();
//         PaymentDeletgate payment=service.ProcessPayment;
//         decimal amount=5000;
//         if (amount.IsValidPayment())
//         {
//             payment(amount);
//         }
//         else
//         {
//             Console.WriteLine("Invalid Payment");
//         }
//     }
// }

////###############################################################################################

// using System;
// delegate void OrderDelegate(string OrderId);
// class NotificationService
// {
//     public void SendEmail(string Id)
//     {
//         Console.WriteLine("Email sent for order "+Id);
//     }
//     public void SendSMS(String Id)
//     {
//         Console.WriteLine("SMS sent for order "+Id);
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         NotificationService service=new NotificationService();
//         OrderDelegate notify=null;
//         notify+=service.SendEmail;
//         notify+=service.SendSMS;
//         notify("ORD1001");
//     }
// }


////#################################### ACTION DELEGATE (LOGGING USER ACTIVITY) #############################################

// using System;
// class Program
// {
//     static void Main()
//     {
//         Action<string> logActivity=message=> Console.WriteLine("Log Entry: "+message);
//         logActivity("User logges in at 10.30");
//     }
// }


// //#################################### DISCOUNT CALCULATION #############################################

// using System;
// class Program
// {
//     static void Main()
//     {
//         Func<decimal,decimal,decimal> calculateDiscount=(price,discount)=> price-(price*discount/100);
//         Console.WriteLine(calculateDiscount(1000,10));
//     }
// }

// //#################################### PREDICATE DELEGATE #############################################

// using System;
// class Program
// {
//     static void Main()
//     {
//         Predicate<int> isEligible=age=> age>=18;
//         Console.WriteLine(isEligible(20));
//     }
// }

// //#################################### Anonymous Delegate #############################################

// using System;
// delegate void ErrorDelegate(string message);
// class Program
// {
//     static void Main()
//     {
//         ErrorDelegate errorHandler = delegate (string msg)
//         {
//             Console.WriteLine("Error: " + msg);
//         };
//         errorHandler("File not found");
//     }
// }



////#################################### Event Delegate #############################################

// using System;
// class Button
// {
//     public delegate void ClickHandler();
//     public event ClickHandler Clicked;
//     public void Click()
//     {
//         Clicked?.Invoke();
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Button btn=new Button();
//         btn.Clicked+=() =>Console.WriteLine("Button was clicked.");
//         btn.Clicked +=()=>Console.WriteLine("Showing message on screen.");
//         btn.Clicked += ()=> Console.WriteLine("Playing click sound.");
//         btn.Click();
//     }
// }


////############################################### MULTICAST DELEGATE ######################################################endregion


// using System;
// using System.Collections.Generic;

// namespace SmartHomeSecurity
// {
//     // 1. DEFINITION: The "Contract" for any security response.
//     // Any method responding to an alert must be void and take a string location.

//     public delegate void SecurityAction(string zone); // definition

//     public class MotionSensor
//     {
//         // The delegate instance (The Panic Button)
//         public SecurityAction OnEmergency; // instance creation

//         public void DetectIntruder(string zoneName)
//         {
//             Console.WriteLine($"[SENSOR] Motion detected in {zoneName}!");
            
//             // 3. INVOCATION: Triggering the Panic Button
//             if (OnEmergency != null)
//             {
//                 OnEmergency(zoneName); // string value = Main Lobby or panicSequence?
//             }
//         }
//     }

//     // Diverse classes that don't know about each other
//     public class AlarmSystem
//     {
//         public void SoundSiren(string zone) => Console.WriteLine($"[ALARM] WOO-OOO! High-decibel siren active in {zone}.");
//     }

//     public class PoliceNotifier
//     {
//         public void CallDispatch(string zone) => Console.WriteLine($"[POLICE] Notifying local precinct of intrusion in {zone}.");
//     }

//     class Program
//     {
//         static void Main()
//         {
//             // Objects Initialization
//             MotionSensor livingRoomSensor = new MotionSensor();
//             AlarmSystem siren = new AlarmSystem();
//             PoliceNotifier police = new PoliceNotifier();

//             // 2. INSTANTIATION & MULTICASTING
//             // We "Subscribe" different methods to the sensor's delegate
//             SecurityAction panicSequence = siren.SoundSiren; // Assignment of methods
//             panicSequence += police.CallDispatch;

//             // Linking the sequence to the sensor
//             livingRoomSensor.OnEmergency = panicSequence;
// 	// class_object.delegate_instance = delegate_instance_multicast

//             // Simulation
//             livingRoomSensor.DetectIntruder("Main Lobby");
//         }
//     }
// }


////#####################################################################################################endregion

/*
using System;
using System.Threading;

namespace CallbackDemo
{
    // STEP 1: Define the Delegate
    public delegate void DownloadFinishedHandler(string fileName);

    class FileDownloader
    {
        // STEP 2: Method that accepts the callback
        public void DownloadFile(string name, DownloadFinishedHandler callback)
        {
            Console.WriteLine($"Starting download: {name}...");
            
            // Simulating work
            Thread.Sleep(2000); 
            
            Console.WriteLine($"{name} download complete.");

            // STEP 3: Execute the Callback
            if (callback != null)
            {
                callback(name); 
            }
        }
    }

    class Program
    {
        // STEP 4: The actual Callback Method
        static void DisplayNotification(string file)
        {
            Console.WriteLine($"NOTIFICATION: You can now open {file}.");
        }

        static void Main()
        {
            FileDownloader downloader = new FileDownloader();

            // Pass the method 'DisplayNotification' as a callback
            downloader.DownloadFile("Presentation.pdf", DisplayNotification);
        }
    }
}

*/

using System;
class Program
{
    static void Main()
    {
        EcommerceOrderCaller.EcommerceOutput();
    }
}
=======
﻿// using System;
// delegate void PaymentDeletgate(decimal amount);
// class PaymentService
// {
//     public void ProcessPayment(decimal amount)
//     {
//         Console.WriteLine("Payment of "+amount+ " processed successfully.");
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         PaymentServise servise=new PaymentServise();
//         PaymentDeletgate payment=servise.ProcessPayment;
//         payment(5000);
//     }
// }

////###############################################################################################

// static class PaymentExtensions
// {
//     public static bool IsValidPayment(this decimal amount)
//     {
//         return amount>0 && amount <= 1_000_000;
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         PaymentService service=new PaymentService();
//         PaymentDeletgate payment=service.ProcessPayment;
//         decimal amount=5000;
//         if (amount.IsValidPayment())
//         {
//             payment(amount);
//         }
//         else
//         {
//             Console.WriteLine("Invalid Payment");
//         }
//     }
// }

////###############################################################################################

// using System;
// delegate void OrderDelegate(string OrderId);
// class NotificationService
// {
//     public void SendEmail(string Id)
//     {
//         Console.WriteLine("Email sent for order "+Id);
//     }
//     public void SendSMS(String Id)
//     {
//         Console.WriteLine("SMS sent for order "+Id);
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         NotificationService service=new NotificationService();
//         OrderDelegate notify=null;
//         notify+=service.SendEmail;
//         notify+=service.SendSMS;
//         notify("ORD1001");
//     }
// }


////#################################### ACTION DELEGATE (LOGGING USER ACTIVITY) #############################################

// using System;
// class Program
// {
//     static void Main()
//     {
//         Action<string> logActivity=message=> Console.WriteLine("Log Entry: "+message);
//         logActivity("User logges in at 10.30");
//     }
// }


// //#################################### DISCOUNT CALCULATION #############################################

// using System;
// class Program
// {
//     static void Main()
//     {
//         Func<decimal,decimal,decimal> calculateDiscount=(price,discount)=> price-(price*discount/100);
//         Console.WriteLine(calculateDiscount(1000,10));
//     }
// }

// //#################################### PREDICATE DELEGATE #############################################

// using System;
// class Program
// {
//     static void Main()
//     {
//         Predicate<int> isEligible=age=> age>=18;
//         Console.WriteLine(isEligible(20));
//     }
// }

// //#################################### Anonymous Delegate #############################################

// using System;
// delegate void ErrorDelegate(string message);
// class Program
// {
//     static void Main()
//     {
//         ErrorDelegate errorHandler = delegate (string msg)
//         {
//             Console.WriteLine("Error: " + msg);
//         };
//         errorHandler("File not found");
//     }
// }



////#################################### Event Delegate #############################################

// using System;
// class Button
// {
//     public delegate void ClickHandler();
//     public event ClickHandler Clicked;
//     public void Click()
//     {
//         Clicked?.Invoke();
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Button btn=new Button();
//         btn.Clicked+=() =>Console.WriteLine("Button was clicked.");
//         btn.Clicked +=()=>Console.WriteLine("Showing message on screen.");
//         btn.Clicked += ()=> Console.WriteLine("Playing click sound.");
//         btn.Click();
//     }
// }


////############################################### MULTICAST DELEGATE ######################################################endregion


// using System;
// using System.Collections.Generic;

// namespace SmartHomeSecurity
// {
//     // 1. DEFINITION: The "Contract" for any security response.
//     // Any method responding to an alert must be void and take a string location.

//     public delegate void SecurityAction(string zone); // definition

//     public class MotionSensor
//     {
//         // The delegate instance (The Panic Button)
//         public SecurityAction OnEmergency; // instance creation

//         public void DetectIntruder(string zoneName)
//         {
//             Console.WriteLine($"[SENSOR] Motion detected in {zoneName}!");
            
//             // 3. INVOCATION: Triggering the Panic Button
//             if (OnEmergency != null)
//             {
//                 OnEmergency(zoneName); // string value = Main Lobby or panicSequence?
//             }
//         }
//     }

//     // Diverse classes that don't know about each other
//     public class AlarmSystem
//     {
//         public void SoundSiren(string zone) => Console.WriteLine($"[ALARM] WOO-OOO! High-decibel siren active in {zone}.");
//     }

//     public class PoliceNotifier
//     {
//         public void CallDispatch(string zone) => Console.WriteLine($"[POLICE] Notifying local precinct of intrusion in {zone}.");
//     }

//     class Program
//     {
//         static void Main()
//         {
//             // Objects Initialization
//             MotionSensor livingRoomSensor = new MotionSensor();
//             AlarmSystem siren = new AlarmSystem();
//             PoliceNotifier police = new PoliceNotifier();

//             // 2. INSTANTIATION & MULTICASTING
//             // We "Subscribe" different methods to the sensor's delegate
//             SecurityAction panicSequence = siren.SoundSiren; // Assignment of methods
//             panicSequence += police.CallDispatch;

//             // Linking the sequence to the sensor
//             livingRoomSensor.OnEmergency = panicSequence;
// 	// class_object.delegate_instance = delegate_instance_multicast

//             // Simulation
//             livingRoomSensor.DetectIntruder("Main Lobby");
//         }
//     }
// }


////#####################################################################################################endregion


using System;
using System.Threading;

namespace CallbackDemo
{
    // STEP 1: Define the Delegate
    public delegate void DownloadFinishedHandler(string fileName);

    class FileDownloader
    {
        // STEP 2: Method that accepts the callback
        public void DownloadFile(string name, DownloadFinishedHandler callback)
        {
            Console.WriteLine($"Starting download: {name}...");
            
            // Simulating work
            Thread.Sleep(2000); 
            
            Console.WriteLine($"{name} download complete.");

            // STEP 3: Execute the Callback
            if (callback != null)
            {
                callback(name); 
            }
        }
    }

    class Program
    {
        // STEP 4: The actual Callback Method
        static void DisplayNotification(string file)
        {
            Console.WriteLine($"NOTIFICATION: You can now open {file}.");
        }

        static void Main()
        {
            FileDownloader downloader = new FileDownloader();

            // Pass the method 'DisplayNotification' as a callback
            downloader.DownloadFile("Presentation.pdf", DisplayNotification);
        }
    }
}




////######################################### ECOMMERCE ASSIGNMENT ############################################################


using System;
class Program
{
    static void Main()
    {
        EcommerceOrderCaller.EcommerceOutput();
    }
}














>>>>>>> c45fc69d5fbdbfb4fff8724ca36ffc9b5e9691a5
