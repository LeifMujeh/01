class Varelse
{
    protected int intelligens = 0;
    protected int tålighet = 0;
    protected int styrka = 0;
    protected Random gen = new Random();

    public int spelaSchack()
    {

        int result = Random.Shared.Next(0, 10) + intelligens;

        // Make sure return value isn't higher than 20
        if (result > 20)
        {
            return 20;
        }
        else
        {
            return result;
        }

    }

    public int brottning()
    {

        return 1;
    }

    public int armbrytning()
    {

        return 1;
    }
}