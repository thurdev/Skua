/*
name: Timestream
description: This is the third part of the Shadow War story arc. It will take you to the Timestream area and start the quest.
tags: story, quest, shadow-war, timestream
*/
//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreStory.cs
//cs_include Scripts/CoreFarms.cs
//cs_include Scripts/CoreAdvanced.cs
//cs_include Scripts/Story/ShadowsOfWar/CoreSoW.cs
using Skua.Core.Interfaces;

public class Timestream
{
    public IScriptInterface Bot => IScriptInterface.Instance;
    public CoreBots Core => CoreBots.Instance;
    public CoreSoW SoW = new();
    public void ScriptMain(IScriptInterface bot)
    {
        Core.SetOptions();

        SoW.Timestream();

        Core.SetOptions(false);
    }
}
