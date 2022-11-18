//public enum GunType
//{
//    WaterGun,
//    Gun,
//    Knife
//}


//public class Hero
//{ 
//    public void Attack(GunType gunType)
//    {
//        switch (gunType)
//        {
//            case GunType.WaterGun:
//                Console.WriteLine("Attack by watergun");
//                break;
//            case GunType.Gun:
//                Console.WriteLine("Attack by gun");
//                break;
//            case GunType.Knife:
//                Console.WriteLine("Attack by knife");
//                break;
//        }
//    }
//}


using Strategy;

Hero hero = new Hero("Hero");
hero.Attack();
hero.SetWeapon(new Gun());
hero.Attack();
hero.SetWeapon(new WaterGun());
hero.Attack();
