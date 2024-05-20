class Varelse
{
    protected int intelligens = 0;
    protected int tålighet = 0;
    protected int styrka = 0;
    protected Random gen = new Random();

    public int spelaSchack()
    {

        int result = Random.Shared.Next(0, 10) + intelligens;

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
        int result = Random.Shared.Next(0, 10) + tålighet + styrka;

      if (result > 20)
        {
            return 20;
        }
        else
        {
            return result;
        }
    }

    public int armbrytning()
    {

       int result = Random.Shared.Next(0, 10) + styrka;

      if (result > 25)
        {
            return 25;
        }
        else
        {
            return result;
        }
    }
}