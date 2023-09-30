using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bot_common
{


    public class Rootobject
    {
        public Channels Channels { get; set; }
        public Botsrights BotsRights { get; set; }
    }

    public class Channels
    {
        public long AideAuxDevoirsChan { get; set; }
    }

    public class Botsrights
    {
        public Monsieurgarrissonid MonsieurGarrissonID { get; set; }
        public Monsieuresclaveid MonsieurEsclaveID { get; set; }
    }

    public class Monsieurgarrissonid
    {
        public string[] AuthorizedChannels { get; set; }
    }

    public class Monsieuresclaveid
    {
        public string[] AuthorizedChannels { get; set; }
    }
}