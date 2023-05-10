using NativeSharp;
using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Text;

namespace AmoungUs
{
    public class Player
    {
        public string? Name { get; set; }
        public PlayerRol Rol { get; set; }
        public PlayerTeam Team { get; set; }
        public int Level { get; set; }
        public bool Can_Use_Kill_Button { get; set; }
        public bool Can_Be_Killed { get; set; }
        public bool Can_Vent { get; set; }
        public bool Protected_By_Guardiand_This_Round { get; set; }
        public bool Protected_By_Guardian { get; set; }
        public bool Dead { get; set; }
        public float Speed { get; set; }
        public float Speed_Ghost { get; set; }
        public float Kill_Timer { get; set; }
        public int Remeaning_Emetgencies { get; set; }
        
    }

    public enum PlayerTeam
    {
        Good,
        Evil
    }

    public enum PlayerRol 
    {
        Crew_Mate,
        IMPOSTER,
        Scientist,
        Engginer,
        Guardian_Angel,
        Shep_Shifer
    }

    public unsafe class AmoungUS
    {
        #region ADDRESS
        int BASE_ADDRESS = 0;
        int PLAYER_BASE = 0x25514780;
    #endregion

        uint id { set; get; }
        NativeProcess? process { set; get; }

        public Player[]? Players { private set; get; }

        public void Init()
        {
            id = 0;
            process = null;
            Players = null;

            var procesos = NativeProcess.GetProcessIdsByName("Among Us.exe");

            foreach (var proceso in procesos)
            {
                Debug.WriteLine($"[PROCESO] {proceso}");
            }

            if (procesos.Count() == 0)
            {
                return;
            }

            Players = new Player[15];

            for (int i = 0; i < Players.Length; i++)
            {
                Players[0] = new Player();
            }

            id = procesos.FirstOrDefault();
            process = NativeProcess.Open(id);
   
            var module = process.GetModule("GameAssembly.dll");
          

            BASE_ADDRESS = ((int)module.Handle + 0x7DC022);

            Debug.WriteLine($"[module] {(BASE_ADDRESS).ToString("X8")} == {(0x308015E8).ToString("X8")}");

            int* _base = (int*)(BASE_ADDRESS );
            Pointer pBase = new Pointer(_base, 0x24, 0x8, 0x10, 0x28);
            PLAYER_BASE = process.ReadInt32(process.ToAddress(pBase));
            Debug.WriteLine($"[player_base] {PLAYER_BASE.ToString("X8")}");
        }

        public bool Load()
        {
            int* _addr = null;

            if (process == null)
            {
                return false;
            }

            _addr = (int*)PLAYER_BASE;
            Pointer pName = new Pointer(_addr, 0x50, 0x3C, 0x24, 0x80, 0xC);

            string _name = process.ReadString(process.ToAddress(pName), true, Encoding.Unicode);
            Players[0].Name = _name;

            _addr = (int*)(PLAYER_BASE + 0xC);
            int _rol = process.ReadInt32(_addr);
            Players[0].Rol = (PlayerRol)_rol;

            _addr = (int*)(PLAYER_BASE + 0x3C);
            int _team = process.ReadInt32(_addr);
            Players[0].Team = (PlayerTeam)_team;

            _addr = (int*)PLAYER_BASE;
            Pointer pLevel = new Pointer(_addr, 0x50, 0x50, 0x20);

            int _level = process.ReadInt32(process.ToAddress(pLevel));
            Players[0].Level = _level;

            return true;
        }
    }
}
