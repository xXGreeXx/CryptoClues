using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelHandler {

    public List<Level> levels = new List<Level>();

    //constructor
    public LevelHandler()
    {
        string clue = 
            "Those without wings wish that they might, But always keep away from the light,For it might forever end your flight,And one man ignored this write,Who could it be, stuck in this plight? THREATEN WHEY SKIES."
            + "Once you solve that you will need that to solve this: Vkcv dgj uo wuj, jwt pim pcvv u oias ki yw. K hfjw bje rhsotad ufl tiuxdm yajh’l bqo yujl. Jeiy’k gqui hwfv mvmkiie ki vmeouy! Ab ks fhdg qnv qgzf sf nziv mlml ugae nziv ik ck uwcy maurlvl lpcn pim ukgyn lpknb. Bwzg ik ck: Eknxm. Tby, tyy cma ij udaq tyy oia tf oftqcb ifm qf kbw tqcbm.";
        Level l = new Level(clue, 1);
        levels.Add(l);
    }
}
