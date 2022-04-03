using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *     SimpleRemoteControl test
             * 
            var remote = new SimpleRemoteControl();
            var light = new Light();
            var garageDoor = new GarageDoor();
            var lightOn = new LightOnCommand(light);
            var garageOpen = new GarageDoorOpenCommand(garageDoor);

            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();
            remote.SetCommand(garageOpen);
            remote.ButtonWasPressed();
            */

            // Regular remote control
            var remoteControl = new RemoteControl();

            var livingRoomLight = new Light("Living Room");
            var livingRoomTV = new TV("Living room");
            var kitchenLight = new Light("Kitchen");
            var ceilingFan = new CeilingFan("Living Room");
            var garageDoor = new GarageDoor("Garage");
            var livingRoomStereo = new Stereo("Living Room");
            var hottub = new Hottub();

            // Replace these commands with actions/delegates
            var livingRoomLightOn = new LightOnCommand(livingRoomLight);
            var livingRoomLightOff = new LightOffCommand(livingRoomLight);
            //var kitchenLightOn = new LightOnCommand(kitchenLight);
            //var kitchenLightOff = new LightOffCommand(kitchenLight);

            //var ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            //var ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            //var ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            //var garageDoorUp = new GarageDoorUpCommand(garageDoor);
            //var garageDoorDown = new GarageDoorDownCommand(garageDoor);

            var livingRoomStereoOn = new StereoOnCommand(livingRoomStereo);
            var livingRoomStereoOff = new StereoOffCommand(livingRoomStereo);

            var livingRoomTVOn = new TVOnCommand(livingRoomTV);
            var livingRoomTVOff = new TVOffCommand(livingRoomTV);
            var hottubOn = new HottubOnCommand(hottub);
            var hottubOff = new HottubOffCommand(hottub);

            // Party macro commands
            ICommand[] partyOn = { livingRoomLightOn, livingRoomStereoOn, livingRoomTVOn, hottubOn };
            ICommand[] partyOff = { livingRoomLightOff, livingRoomStereoOff, livingRoomTVOff, hottubOff };

            var partyOnMacro = new MacroCommand(partyOn);
            var partyOffMacro = new MacroCommand(partyOff);

            remoteControl.SetCommandStandard(0, partyOnMacro, partyOffMacro);

            //remoteControl.SetCommandStandard(0, ceilingFanMedium, ceilingFanOff);
            //remoteControl.SetCommandStandard(1, ceilingFanHigh, ceilingFanOff);
            //remoteControl.SetCommand(0, () => livingRoomLight.On(), () => livingRoomLight.Off());
            //remoteControl.SetCommand(1, () => kitchenLight.On(), () => kitchenLight.Off());
            //remoteControl.SetCommand(2, () => ceilingFan.High(), () => ceilingFan.Off());
            //remoteControl.SetCommand(3, () => stereo.SetCD(), () => stereo.Off());

            // Output remote control panel
            // It overrides ToString() method
            //Console.WriteLine(remoteControl);

            // The lambda expression doesn't work if we have two abstract methods in ICommand

            Console.WriteLine(remoteControl);
            Console.WriteLine("--- Pushing Macro On---");
            remoteControl.OnButtonWasPushed(0);
            Console.WriteLine("\n--- Pushing Macro Off---");
            remoteControl.OffButtonWasPushed(0);
            //remoteControl.UndoButtonWasPushed();

            //remoteControl.OnButtonWasPushed(1);
            //Console.WriteLine(remoteControl);
            //remoteControl.OffButtonWasPushed(0);
            //remoteControl.UndoButtonWasPushed();

            //remoteControl.OnButtonWasPushed(1);
            //remoteControl.OffButtonWasPushed(1);
            //remoteControl.OnButtonWasPushed(2);
            //remoteControl.OffButtonWasPushed(2);
            //remoteControl.OnButtonWasPushed(3);
            //remoteControl.OffButtonWasPushed(3);

            Console.ReadKey();
        }
    }
}
