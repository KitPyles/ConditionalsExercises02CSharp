using System;

class MainClass {
  public static void Main (string[] args) {
    
    // string engineIndicatorLight = "red blinking";
    bool spaceSuitsOn = true;
    bool shuttleCabinReady = true;
    bool crewStatus = spaceSuitsOn && shuttleCabinReady;
    int computerStatusCode = 200;
    int shuttleSpeed = 15000;

    // 3) Write conditional expressions to satisfy the following safety rules:
    // a) If crewStatus is true, print "Crew Ready" else print "Crew Not Ready".
    if (crewStatus == true) {
      Console.WriteLine("Crew Ready");
    } else {
      Console.WriteLine("Crew Not Ready");
    }


    // b) If computerStatusCode is 200, print "Please stand by. Computer is rebooting." Else if computerStatusCode is 400, print "Success! Computer online." Else print "ALERT: Computer offline!"
    if (computerStatusCode == 200) {
      Console.WriteLine("Please stand by. Computer is rebooting.");
    } else if (computerStatusCode == 400) {
      Console.WriteLine("Success! Computer is online.");
    } else {
      Console.WriteLine("ALERT: Computer offline!");
    }

    // c) If shuttleSpeed is > 17,500, print "ALERT: Escape velocity reached!" Else if shuttleSpeed is < 8000, print "ALERT: Cannot maintain orbit!" Else print "Stable speed".
    if (shuttleSpeed > 17500) {
      Console.WriteLine("ALERT: Escape velocity reached!");
    } else if (shuttleSpeed < 8000) {
      Console.WriteLine("ALERT: Cannot maintain orbit!");
    } else {
      Console.WriteLine("Stable Speed");
    }

    // 4) PREDICT: Do the code blocks shown in the 'predict.txt' file produce the same result?
    if (crewStatus && computerStatusCode == 200 && spaceSuitsOn)
    {
       Console.WriteLine("all systems go");
    }
    else
    {
       Console.WriteLine("WARNING. Not ready");
    }

    if (!crewStatus || computerStatusCode != 200 || !spaceSuitsOn)
    {
       Console.WriteLine("WARNING.  Not ready");
    }
    else
    {
       Console.WriteLine("all systems go");
    }

    Console.WriteLine("Yes");
  }
}