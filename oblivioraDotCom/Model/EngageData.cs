namespace oblivioraDotCom.Model
{
    public class EngagePair
    {
        public String? Character { get; set; }
        public String? Emblem { get; set; }
    }

    public struct Character
    {
        public Character(String name, int chapter, bool fell)
        {
            this.Name = name;
            this.Chapter = chapter;
            this.Fell = fell;
        }

        public string Name;
        public int Chapter;
        public bool Fell;
    }

    public struct Emblem
    {
        public Emblem(String name, int[] chapters, bool dlc)
        {
            this.Name = name;
            this.Chapters = chapters;
            this.DLC = dlc;
        }

        public string Name;
        public int[] Chapters;
        public bool DLC;
    }

    public class EngageLists
    {
        public readonly static Character[] Characters = new Character[] {
            new Character("Alear",0,false),
            new Character("Vander",1,false),
            new Character("Clanne",2,false),
            new Character("Framme",2,false),
            new Character("Alfred",3,false),
            new Character("Etie",3,false),
            new Character("Boucheron",3,false),
            new Character("Celine",4,false),
            new Character("Chloe",4,false),
            new Character("Louis",4,false),
            new Character("Jean",6,false),
            new Character("Diamant",8,false),
            new Character("Amber",8,false),
            new Character("Jade",9,false),
            new Character("Alcryst",7,false),
            new Character("Citrinne",7,false),
            new Character("Lapis",7,false),
            new Character("Yunaka",6,false),
            new Character("Saphir",19,false),
            new Character("Ivy",11,false),
            new Character("Kagetsu",11,false),
            new Character("Zelkov",11,false),
            new Character("Hortensia",14,false),
            new Character("Rosado",16,false),
            new Character("Goldmary",16,false),
            new Character("Anna",7,false),
            new Character("Lindon",18,false),
            new Character("Timerra",13,false),
            new Character("Panette",13,false),
            new Character("Merrin",13,false),
            new Character("Fogado",12,false),
            new Character("Pandreo",12,false),
            new Character("Bunet",12,false),
            new Character("Seadall",16,false),
            new Character("Mauvier",21,false),
            new Character("Veyle",22,false),
            new Character("Nel",6,true),
            new Character("Nil",6,true),
            new Character("Gregory",6,true),
            new Character("Madeline",6,true),
            new Character("Zelestia",6,true)
        };

        public readonly static Emblem[] Emblems = new Emblem[] {
            new Emblem("Marth",new[]{0,1,2,3,4,5,6,7,8,9,10,11,24,25,26},false),
            new Emblem("Celica",new[]{5,6,7,8,9,10,11,21,22,23,24,25,26},false),
            new Emblem("Sigurd",new[]{5,6,7,8,9,10,11,18,19,20,21,22,23,24,25,26},false),
            new Emblem("Leif",new[]{9,10,11,18,19,20,21,22,23,24,25,26},false),
            new Emblem("Roy",new[]{9,10,11,20,21,22,23,24,25,26},false),
            new Emblem("Lyn",new[]{12,13,14,15,16,17,18,19,20,21,22,23,24,25,26},false),
            new Emblem("Eirika",new[]{17,18,19,20,21,22,23,24,25,26},false),
            new Emblem("Ike",new[]{14,15,16,17,18,19,20,21,22,23,24,25,26},false),
            new Emblem("Micaiah",new[]{7,8,9,10,11,19,20,21,22,23,24,25,26},false),
            new Emblem("Lucina",new[]{12,13,14,15,16,17,18,19,20,21,22,23,24,25,26},false),
            new Emblem("Corrin",new[]{16,17,18,19,20,21,22,23,24,25,26},false),
            new Emblem("Byleth",new[]{15,16,17,18,19,20,21,22,23,24,25,26},false),
            new Emblem("Tiki",new[]{6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26},true),
            new Emblem("Hector",new[]{6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26},true),
            new Emblem("Soren",new[]{6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26},true),
            new Emblem("Chrom",new[]{6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26},true),
            new Emblem("Camilla",new[]{6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26},true),
            new Emblem("Edelgard",new[]{6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26},true),
            new Emblem("Veronica",new[]{6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26},true)
        };

        public static List<string> getCharacters(int chapter, bool fell)
        {
            Character[] filtered = Array.FindAll(Characters, chara => chara.Chapter < chapter && !(chara.Fell && !fell));
            return filtered.Select(chara => chara.Name).ToList();
        }

        public static List<string> getEmblems(int chapter, bool dlc)
        {
            Emblem[] filtered = Array.FindAll(Emblems, chara => Array.IndexOf(chara.Chapters, chapter) > -1 && !(chara.DLC && !dlc));
            return filtered.Select(chara => chara.Name).ToList();
        }
    }

    public class EngageRequest
    {
        public int units { get; set; }
        public string? alear { get; set; }
        public string? dlc { get; set; }
        public string? fell { get; set; }
        public int chapter { get; set; }
    }
}
