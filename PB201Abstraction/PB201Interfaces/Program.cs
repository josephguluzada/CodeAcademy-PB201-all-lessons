namespace PB201Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AK47 aK47 = new();

            aK47.Name = "AK47 yeni";
            aK47.MagazineSize = 30;
            aK47.CurrentAmmo = 13;
            aK47.ReloadTime = 4.5;
            aK47.Shoot();
            aK47.Fire();
            aK47.Reload();


            Deagle deagle = new();

            deagle.Name = "Polatin tapancasi kinodan";
            deagle.MagazineSize = 7;
            deagle.CurrentAmmo = 7;
            deagle.ReloadTime = 5;
            deagle.Shoot();
            deagle.Reload();

            Glock18 glock18 = new();

            glock18.Name = "Glock 18";
            glock18.MagazineSize = 20;
            glock18.CurrentAmmo = 17;
            glock18.ReloadTime = 3;
            glock18.Shoot();
            glock18.Fire();
            glock18.Reload();

            
        }
    }
}
