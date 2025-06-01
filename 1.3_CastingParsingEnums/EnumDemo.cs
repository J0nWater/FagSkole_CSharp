namespace _1._3_CastingParsingEnums;

public class EnumDemo
{
    public static void Run()
    {
        int trafficLight = 3;
        TrafficLight currentState = TrafficLight.Green;
        
        TrafficLight parsedTrafficLight = (TrafficLight)trafficLight;

        var traffikLightState = "RedAndYellow";
        var successfullyParsed = Enum.TryParse(traffikLightState, out TrafficLight newState);
        
        ChangeTrafficLightState(TrafficLight.RedAndYellow);
    }

    public static void ChangeTrafficLightState(TrafficLight newState)
    {
        // update state to new state
    }
}