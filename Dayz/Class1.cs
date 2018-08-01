using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfinityScript;
using System.Runtime.InteropServices;
using System.IO;
namespace Dayz
{
    public class Dayz : BaseScript
    {
        
        public Random Rand = new Random();
        public struct Item
        {
            public string Name;
            public string itemid;
            public Vector3 Place;
            public string modell;
            public Entity moddelentity;
            public bool showentity;
        }       

        public List<Vector3> ItemPlaces = new List<Vector3>();
        public List<Item> Items = new List<Item>();

        public Dayz()
            : base()
        {
            this.changeGametype("^2LSD_DayZ");
            InitItems();
            GenerateItems();
            base.PlayerConnected += PlayerConnecte;
        }

        public void InitItems()
        {
            if (getDvar<string>("mapname").Equals("mp_interchange"))
            {
                /*AddItemSpawn(-5136.251F, 9455.421F, 512.1249F);
                AddItemSpawn(-6891.003F, 11315.72F, 512.125F);
                AddItemSpawn(-3907.517F, 11533.7F, 512.125F);
                AddItemSpawn(-6071.082F, 13312.13F, 512.125F);
                AddItemSpawn(-6433.944F, 15621.27F, 512.125F);
                AddItemSpawn(-4766.018F, 15782.49F, 512.125F);
                AddItemSpawn(-2307.318F, 16683.29F, 512.125F);
                AddItemSpawn(-3104.113F, 19497.44F, 512.125F);
                AddItemSpawn(-3185.167F, 15699.35F, 512.125F);
                AddItemSpawn(-2578.224F, 14489.43F, 512.125F);*/
                AddItemSpawn(-6825.479F, 13297.25F, 512.125F);
                AddItemSpawn(-6068.507F, 16313.76F, 512.125F);
                AddItemSpawn(-3121.024F, 16320.23F, 512.125F);
                AddItemSpawn(-1346.608F, 17824.82F, 512.125F);
                AddItemSpawn(-1843.509F, 14532.81F, 512.125F);
                AddItemSpawn(-3156.776F, 10722.9F, 512.125F);

                AddItemSpawn(-4170.216F, 8476.819F, 512.125F);
                AddItemSpawn(-2384.21F, 11925.62F, 512.125F);
                AddItemSpawn(-3475.709F, 12132.83F, 512.125F);
                AddItemSpawn(-5765.204F, 12015.97F, 512.125F);
                AddItemSpawn(-5695.092F, 14548.82F, 512.125F);
                AddItemSpawn(-2082.704F, 19374.7F, 512.125F);
                AddItemSpawn(-4568.252F, 15673.49F, 512.125F);
                AddItemSpawn(-3254.936F, 15020.7F, 512.125F);
                AddItemSpawn(-4379.035F, 14797.06F, 512.125F);
            }
            else if (getDvar<string>("mapname").Equals("mp_bravo"))
            {
                AddItemSpawn(78.59523F, -1934.841F, 1120.176F);
                AddItemSpawn(419.3744F, -1705.077F, 1086.125F);
                AddItemSpawn(293.925F, -2148.229F, 1114.125F);
                AddItemSpawn(440.9026F, -2829.262F, 1032.737F);
                AddItemSpawn(71.76965F, -3112.199F, 1003.27F);
                AddItemSpawn(65.71988F, -3316.525F, 1002.125F);
                AddItemSpawn(-288.651F, -3255.304F, 1002.125F);
                AddItemSpawn(-539.4645F, -3119.932F, 1002.125F);
                AddItemSpawn(-689.1412F, -3037.931F, 1002.125F);
                AddItemSpawn(-1022.989F, -3112.324F, 1002.124F);
                AddItemSpawn(-1529.163F, -3149.588F, 1002.124F);
                AddItemSpawn(-1447.721F, -3357.333F, 1004.338F);
                AddItemSpawn(-2119.976F, -3429.886F, 1151.127F);
                AddItemSpawn(-2205.615F, -2852.85F, 1066.125F);
                AddItemSpawn(-2602.741F, -2253.271F, 1164.974F);
                AddItemSpawn(-2905.379F, -2134.168F, 1176.585F);
                AddItemSpawn(-2726.493F, -1560.001F, 1214.407F);
                AddItemSpawn(-2484.114F, -1383.791F, 1201.447F);
                AddItemSpawn(-1901.464F, -1571.73F, 1236.848F);
                AddItemSpawn(-1153.578F, -999.1232F, 1150.125F);
                AddItemSpawn(-1305.02F, -976.6174F, 1155.462F);
                AddItemSpawn(-1448.471F, -914.625F, 1168.125F);
                AddItemSpawn(-1735.416F, -753.3254F, 1020.125F);
                AddItemSpawn(-2659.073F, 81.30791F, 1071.094F);
                AddItemSpawn(-3373.001F, 355.9863F, 1284.336F);
                AddItemSpawn(-3301.961F, 716.6655F, 1267.209F);
                AddItemSpawn(-3476.779F, 1167.937F, 1302.215F);
                AddItemSpawn(-3488.966F, 979.095F, 1294.623F);
                AddItemSpawn(-4238.035F, 2155.913F, 1444.895F);
                AddItemSpawn(-4719.071F, 2536.286F, 1519.894F);
                AddItemSpawn(-5533.156F, 2901.615F, 1584.125F);
                AddItemSpawn(-2262.702F, 4511.171F, 1580.125F);
                AddItemSpawn(-1737.479F, 4608.229F, 1580.125F);
                AddItemSpawn(-1429.314F, 4767.885F, 1580.125F);
                AddItemSpawn(-1053.359F, 4995.626F, 1580.125F);
                AddItemSpawn(-729.9524F, 4985.405F, 1580.125F);
                AddItemSpawn(524.3505F, 4972.1F, 1445.542F);
                AddItemSpawn(1073.201F, 5518.879F, 1346.257F);
                AddItemSpawn(1456.409F, 6607.118F, 1261.676F);
                AddItemSpawn(2433.964F, 7004.703F, 1192.35F);
                AddItemSpawn(2140.767F, 7584.763F, 1193.134F);
                AddItemSpawn(2965.052F, 7805.005F, 1191.637F);
                AddItemSpawn(3431.482F, 7991.224F, 1226.231F);
                AddItemSpawn(3726.847F, 7213.841F, 1341.658F);
                AddItemSpawn(4035.519F, 7840.851F, 1229.256F);
                AddItemSpawn(4694.905F, 7566.714F, 1217.021F);
                AddItemSpawn(5180.761F, 7868.513F, 1236.229F);
                AddItemSpawn(4887.377F, 8586.451F, 1265.918F);
                AddItemSpawn(4561.896F, 8973.653F, 1284.519F);
                AddItemSpawn(4150.229F, 9439.372F, 1306.903F);
                AddItemSpawn(3048.745F, 2148.647F, 1332.624F);
                AddItemSpawn(2986.054F, 1771.953F, 1329.068F);
                AddItemSpawn(3026.569F, 1282.654F, 1327.488F);
                AddItemSpawn(2289.578F, 893.8346F, 1248.853F);
                AddItemSpawn(2247.444F, 703.5107F, 1220.214F);
                AddItemSpawn(2301.948F, 213.8899F, 1103.357F);
                AddItemSpawn(2257.684F, -216.6261F, 1104.041F);
                AddItemSpawn(2993.281F, -7.338098F, 1435.325F);
                AddItemSpawn(3225.129F, 267.0239F, 1398.745F);
                AddItemSpawn(3184.921F, 948.875F, 1372.166F);
                AddItemSpawn(3276.359F, -37.94893F, 1600.949F);
                AddItemSpawn(4498.302F, 997.125F, 1576.041F);
                AddItemSpawn(4423.875F, 338.125F, 1564.131F);
                AddItemSpawn(4211.875F, -721.875F, 1617.125F);
                AddItemSpawn(4297.319F, -445.875F, 1635.763F);
                AddItemSpawn(4179.099F, -92.12597F, 1623.404F);
                AddItemSpawn(3175.125F, -78.18441F, 1572.108F);
                AddItemSpawn(2936.235F, -454.6633F, 1485.089F);
                AddItemSpawn(2640.948F, -572.6962F, 1359.231F);
                AddItemSpawn(2649.186F, -832.0579F, 1474.125F);
                AddItemSpawn(2658.559F, -1337.874F, 1515.125F);
                AddItemSpawn(2512.042F, -745.1257F, 1309.926F);
                AddItemSpawn(2201.706F, -1170.462F, 1199.542F);
                AddItemSpawn(1730.906F, -2406.844F, 1183.125F);
                AddItemSpawn(2033.336F, -2836.027F, 1183.125F);
                AddItemSpawn(2234.352F, -3064.85F, 1195.04F);
                AddItemSpawn(2500.89F, -3234.593F, 1251.307F);
                AddItemSpawn(2353.6F, -3790.379F, 1216.488F);
                AddItemSpawn(2120.36F, -3641.087F, 1183.125F);
                AddItemSpawn(1890.547F, -3596.204F, 1183.125F);
                AddItemSpawn(1693.91F, -3286.871F, 1183.125F);
                AddItemSpawn(2445.906F, -4210.572F, 1231.546F);
                AddItemSpawn(2865.942F, -3878.827F, 1285.375F);
                AddItemSpawn(1325.374F, -3254.488F, 1080.048F);
                AddItemSpawn(1256.858F, -2322.8F, 1077.969F);
                AddItemSpawn(1345.889F, -1614.976F, 1093.87F);
                AddItemSpawn(1081.125F, -1169.126F, 1075.065F);

            }
        }
        public HudElem CreateHUD(Entity player)
        {
            HudElem info;
            info = HudElem.CreateFontString(player,"hudbig", 1f);
            info.SetPoint("CENTER", "BOTTOM", 0, -50);
            info.HideWhenInMenu = true;
            info.SetText("Item:^2 G36B");
            info.SetText("");
            return info;
        }
        public void AddItemSpawn(float x,float y,float z)
        {
            ItemPlaces.Add(new Vector3(x,y,z));
        }
        private T getDvar<T>(string dvar)
        {
            // would switch work here? - no
            if (typeof(T) == typeof(int))
            {
                return Call<T>("getdvarint", dvar);
            }
            else if (typeof(T) == typeof(float))
            {
                return Call<T>("getdvarfloat", dvar);
            }
            else if (typeof(T) == typeof(string))
            {
                return Call<T>("getdvar", dvar);
            }
            else if (typeof(T) == typeof(Vector3))
            {
                return Call<T>("getdvarvector", dvar);
            }
            else
            {
                return default(T);
            }
        }
        public void GenerateItems()
        {
            Items.Clear();
            foreach (Vector3 v3 in ItemPlaces)
            {               

                Item i = new Item();
                i.Place = v3;
                i = ItemGenerator(i);
                i.moddelentity = RenderItems(i);
                Items.Add(i);
                Log.Write(LogLevel.All, "Generate: " + i.Name);                
            }
            OnInterval(60000, () =>
            {
                bool giveitmes = false;
                foreach (Item ip in Items)
                {
                    if (ip.moddelentity.GetField<int>("showitem") == 1)
                    {
                        if (ip.itemid.Equals("script_silencer"))
                        { }
                        else
                        {
                            giveitmes = true;
                        }
                    }
                }
                if (giveitmes == true)
                { }
                else
                {
                    RespawnItems();
                }
                return true;
            });
        }
        public void RespawnItems()
        {
            Utilities.RawSayAll("ITEMS RESPAWN NOW!");
            Log.Write(LogLevel.All, "ITEMS RESPAWN NOW!");
            foreach (Item i in Items)
            {
                Item ip = i;
                ip = ItemGenerator(ip);
                ip.moddelentity.Call("setModel", new Parameter[] { ip.modell });
                ip.moddelentity.Call("show");
                ip.moddelentity.SetField("showitem", 1);
                Log.Write(LogLevel.All, "Generate: " + ip.Name);  
            }

        }
        public Item ItemGenerator(Item ip)
        {
           Item i = ip;
            int Randint = Rand.Next(0, 5);
            string IName = "";
            string IItemID = "";
            string Imodell = "";
            if (Randint == 0)
            {
                IName = "G36C";
                IItemID = "iw5_g36c_mp";
                Imodell = "weapon_g36_iw5_gold";
            }
            else if (Randint == 1)
            {
                IName = "MP7";
                IItemID = "iw5_mp7_mp";
                Imodell = "weapon_mp7_iw5_gold";
            }
            else if (Randint == 2)
            {
                IName = "Silencer";
                IItemID = "script_silencer";
                Imodell = "weapon_silencer_03";
            }
            else if (Randint == 3)
            {
                IName = "USP45";
                IItemID = "iw5_usp45_mp";
                Imodell = "weapon_usp45_iw5";
            }
            else if (Randint == 4)
            {
                IName = "Ammo Pack";
                IItemID = "script_ammo";
                Imodell = "weapon_scavenger_grenadebag";
            }
            else
            {
                IName = "G36C";
                IItemID = "iw5_g36c_mp";
                Imodell = "weapon_g36_iw5_gold";
            }

            i.Name = IName;
            i.itemid = IItemID;
            i.modell = Imodell;
            return i;
        }
        public Entity RenderItems(Item i)
        {

                Entity BH = Call<Entity>("spawn", new Parameter[]{
                "script_model",
                i.Place + new Vector3(0.0F,0.0F,2.0F)
                });
                BH.Call("setModel", new Parameter[] { i.modell });
                BH.SetField("angles", new Parameter(new Vector3(0F, 180F, 90F)));
               BH.SetField("showitem", 1);
                /*BH.OnInterval(1, (moddel) =>
                {
                    Vector3 Pos = moddel.GetField<Vector3>("angles") + new Vector3(0F, 5F, 0F);
                    moddel.SetField("angles", new Parameter(Pos));
                    return true;
                });*/
                return BH;
           
        }

        public void PlayerConnecte(Entity Player)
        {
            HudElem info =  CreateHUD(Player);
            Player.SpawnedPlayer += new Action(() =>
            {
                Log.Write(LogLevel.All, Player.CurrentWeapon.ToString());
                Player.TakeAllWeapons();
            });
            Player.OnInterval(1000, (p) =>
            {
                bool havefound = false;
                foreach (Item i in Items)
                {
                    if(PlayerToPoint(100.0F,p,i.Place))
                    {
                        if (i.moddelentity.GetField<int>("showitem") == 1)
                        {                            
                            info.SetText("ITEM: ^2" + i.Name + " ^7press \"^1[{+smoke}]^7\" to pick up!");
                            havefound = true;
                        }
                    }
                }
                if (havefound == false)
                {
                    info.SetText("");
                }
                return true;
            });
            Player.Call("notifyonplayercommand", "pickup", "+smoke");
            Player.OnNotify("pickup", (p) =>
            {
                foreach (Item i in Items)
                {
                    if (PlayerToPoint(100.0F, p, i.Place))
                    {
                        if (i.moddelentity.GetField<int>("showitem") == 1)
                        {
                            i.moddelentity.SetField("showitem", 0);
                            ItemFunc(p, i);
                            break;
                        }
                    }
                }
            }); 
        }

        public void ItemFunc(Entity Player, Item i)
        {            
            if(i.itemid.Equals("iw5_g36c_mp"))
            {
                Player.GiveWeapon(i.itemid);
                Player.SwitchToWeapon(i.itemid);
            }
            if (i.itemid.Equals("iw5_mp7_mp"))
            {
                Player.GiveWeapon(i.itemid);
                Player.SwitchToWeapon(i.itemid);
            }
            if (i.itemid.Equals("iw5_usp45_mp"))
            {
                Player.GiveWeapon(i.itemid);
                Player.SwitchToWeapon(i.itemid);
            }
            if (i.itemid.Equals("script_ammo"))
            {
                string weapon = Player.CurrentWeapon.ToString();
                if (weapon.Equals("none"))
                {
                    Utilities.RawSayTo(Player, "Du musst eine Waffe haben um diese zu befüllen!");
                    i.moddelentity.Call("show");
                    i.moddelentity.SetField("showitem", 1);
                }
                else
                {
                    Player.Call("givemaxammo", new Parameter[] { weapon });
                }
            }
            if (i.itemid.Equals("script_silencer"))
            {                
                string weapon = Player.CurrentWeapon.ToString();
                if(weapon.Equals("none"))
                {
                    Utilities.RawSayTo(Player, "Du kannst nun mit den Silencer werfen.");
                    Player.GiveWeapon("throwingknife_mp");
                    //i.moddelentity.Call("show");
                    //i.moddelentity.SetField("showitem", 1);
                }
                else
                {
                    Player.TakeWeapon(weapon);
                    string newWeapon = weapon + "_silencer_silencer02_silencer03";
                    Player.GiveWeapon(newWeapon);
                    Player.SwitchToWeapon(newWeapon);
                }
            }
            //i.moddelentity.Call("destroy");
            i.moddelentity.Call("hide");
            //Items.Remove(i);
        }        

        public override EventEat OnSay3(Entity player, ChatType type, string name, ref string message)
        {
            /*if (message.Equals("!pos"))
            {
                Log.Write(LogLevel.All,"AddItemSpawn(" + player.Origin.X + "F, " + player.Origin.Y + "F, " + player.Origin.Z + "F);");
                return EventEat.EatGame;
            }
            if (message.Equals("!w"))
            {
                Utilities.RawSayTo(player, player.CurrentWeapon.ToString());
                return EventEat.EatGame;
            }
            if (message.Equals("!t"))
            {
                Utilities.RawSayTo(player, player.GetField<string>("sessionteam"));
                return EventEat.EatGame;
            }*/
            return EventEat.EatNone;
        }

        public bool PlayerToPoint(float radius, Entity Player, Vector3 Pos)
        {
            float rage = Call<float>("distance", new Parameter[] { 
                Player.Origin, 
                Pos
            });
            //Log.Write(LogLevel.All, Player.Name.ToString() + ": " + rage);
            if (rage < radius)
            {
                return true;
            }
            return false;
        }

        #region GameTypeChanger
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr VirtualAlloc(IntPtr lpAddress, UIntPtr dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool VirtualFree(IntPtr lpAddress, UIntPtr dwSize, uint dwFreeType);

        public IntPtr alloc(int size)
        {
            return VirtualAlloc(IntPtr.Zero, (UIntPtr)size, 0x3000, 0x40);
        }

        public bool unalloc(IntPtr address, int size)
        {
            return VirtualFree(address, (UIntPtr)size, 0x8000);
        }

        bool _changed = false;
        IntPtr memory;
        private unsafe void changeGametype(string gametype)
        {
            byte[] gametypestring;
            if (_changed)
            {
                gametypestring = new System.Text.UTF8Encoding().GetBytes(gametype);
                if (gametypestring.Length >= 64) gametypestring[64] = 0x0; // null terminate if too large
                Marshal.Copy(gametypestring, 0, memory, gametype.Length > 64 ? 64 : gametype.Length);
                return;
            }
            memory = alloc(64);
            gametypestring = new System.Text.UTF8Encoding().GetBytes(gametype);
            if (gametypestring.Length >= 64) gametypestring[64] = 0x0; // null terminate if too large
            Marshal.Copy(gametypestring, 0, memory, gametype.Length > 64 ? 64 : gametype.Length);
            *(byte*)0x4EB983 = 0x68; // mov eax, 575D928h -> push stringloc
            *(int*)0x4EB984 = (int)memory;
            *(byte*)0x4EB988 = 0x90; // mov ecx, [eax+0Ch] -> nop
            *(byte*)0x4EB989 = 0x90;
            *(byte*)0x4EB98A = 0x90;
            *(byte*)0x4EB98B = 0x90; // push edx -> nop
            _changed = true;
        }
        #endregion

    }
}
