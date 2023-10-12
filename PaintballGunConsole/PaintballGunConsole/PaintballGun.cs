namespace PaintballGunConsole;

public class PaintballGun
{

    private int balls = 0;

    public int MagazineSize
    {
        get;
        private set;
    } = 16;
    public int BallsLoaded
    {
        get;
        private set;
    }

    public int Balls
    {
        get { return balls; }
        set
        {
            if (value > 0) balls = value;
            Reload();
        }
    }

    public bool IsEmpty()
    {
        return BallsLoaded == 0;
    }

    public void Reload()
    {
        if (balls > MagazineSize) BallsLoaded = MagazineSize;
        else BallsLoaded = balls;
    }

    public bool Shoot()
    {
        if (BallsLoaded == 0) return false;
        BallsLoaded--;
        balls--;
        return true;
    }
    static void Main(string[] args)
    {
        PaintballGun gun = new PaintballGun();
        while (true)
        {
            Console.WriteLine($"{gun.Balls} balls, {gun.BallsLoaded} loaded");
            if (gun.IsEmpty()) Console.WriteLine("WARNING: You're out of ammo");
            Console.WriteLine("Space to shoot, r to reload, + to add ammo, q to quit");
            char key = Console.ReadKey(true).KeyChar;
            if (key == ' ') Console.WriteLine($"Shooting returned {gun.Shoot()}");
            else if (key == 'r') gun.Reload();
            else if (key == '+') gun.Balls += gun.MagazineSize;
            else if (key == 'q') return;
        }
    }
}