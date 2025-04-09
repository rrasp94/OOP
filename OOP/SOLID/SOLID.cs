namespace OOP.SOLID;
public class DIP
{
    public class BadLightBulb
    {
        public bool IsOn { get; set; }
        public void TurnOn() => Console.WriteLine("Light bulb is on.");
        public void TurnOff() => Console.WriteLine("Light bulb is off.");
    }

    public class BadSwitch
    {
        private BadLightBulb _lightBulb;
        public BadSwitch(BadLightBulb lightBulb) => _lightBulb = lightBulb;
        public void Toggle()
        {
            if (_lightBulb.IsOn)
            {
                _lightBulb.TurnOff();
                _lightBulb.IsOn = false;
            }
            else
            {
                _lightBulb.TurnOn();
                _lightBulb.IsOn = true;
            }
        }
    }

    public interface ISwitchable
    {
        public bool IsOn { get; set; }
        void TurnOn();
        void TurnOff();
    }

    public class LightBulb : ISwitchable
    {
        public bool IsOn { get; set; }
        public void TurnOn() => Console.WriteLine("Light bulb is on.");
        public void TurnOff() => Console.WriteLine("Light bulb is off.");
    }

    public class Switch
    {
        private ISwitchable _device;
        public Switch(ISwitchable device) => _device = device;
        public void Toggle()
        {
            if (_device.IsOn)
            {
                _device.TurnOff();
                _device.IsOn = false;
            }
            else
            {
                _device.TurnOn();
                _device.IsOn = true;
            }
        }
    }
}