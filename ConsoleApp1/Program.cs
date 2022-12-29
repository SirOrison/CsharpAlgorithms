class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        int minutes = 40;
        return minutes;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutes)
    {
        
        return ExpectedMinutesInOven() - minutes ;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int minutes)
    {
        return minutes + (layers * 2);
    }
     
    //exercism exercise 2
    
}
