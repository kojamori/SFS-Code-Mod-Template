#if (updateBoilerplate)
using System.Collections.Generic;
using HarmonyLib;
using ModLoader;
using SFS.IO;
using UITools;
using System.Reflection;

#if (fileScopedNamespace)
namespace generatedRootNamespace;

public class entrypointClassName : Mod, IUpdatable
{
    public static entrypointClassName Instance { get; private set; }
    public entrypointClassName()
    {
        Instance = this;
    }
    
    public override string ModNameID => "generatedModNameId";
    public override string DisplayName => "generatedModDisplayName";
    public override string Author => "author";
    public override string MinimumGameVersionNecessary => "minimumGameVersion";
    public override string ModVersion => "modVersion";
    public override string Description => "modDescription";
    public override string IconLink => null;
    public override Action LoadKeybindings => null;

    public override Dictionary<string, string> Dependencies => new Dictionary<string, string>()
    {
        { "UITools", "1.1.6" }
    };

    // Automatic updating using Neptune-Sky's UITools' IUpdatable interface.
    // Details at https://github.com/cucumber-sp/UITools.
    public Dictionary<string, FilePath> UpdatableFiles => new()
    {
        {
            // TODO, REMOVE ONCE LINK IS ADDED!
            "Link/To/Latest/DLL/Release/Goes/Here",
            new FolderPath(ModFolder).ExtendToFile(Assembly.GetExecutingAssembly().GetName().Name + ".dll")
        }
    };
    
    public override void Early_Load()
    { 
    #if (harmony)
        new Harmony(Instance.ModNameID).PatchAll();
    #endif
    }

    public override void Load()
    {
        
    }
}
#else
namespace generatedRootNamespace
{
    public class entrypointClassName : Mod, IUpdatable
    {
        public static entrypointClassName Instance { get; private set; }
        public entrypointClassName()
        {
            Instance = this;
        }
        
        public override string ModNameID => "generatedModNameId";
        public override string DisplayName => "generatedModDisplayName";
        public override string Author => "author";
        public override string MinimumGameVersionNecessary => "minimumGameVersion";
        public override string ModVersion => "modVersion";
        public override string Description => "modDescription";
        public override string IconLink => null;
        public override Action LoadKeybindings => null;

        public override Dictionary<string, string> Dependencies => new Dictionary<string, string>()
        {
            { "UITools", "1.1.6" }
        };
    
        // Automatic updating using Neptune-Sky's UITools' IUpdatable interface.
        // Details at https://github.com/cucumber-sp/UITools.
        public Dictionary<string, FilePath> UpdatableFiles => new()
        {
            {
                // TODO, REMOVE ONCE LINK IS ADDED!
                "Link/To/Latest/DLL/Release/Goes/Here",
                new FolderPath(ModFolder).ExtendToFile(Assembly.GetExecutingAssembly().GetName().Name + ".dll")
            }
        };
        
        public override void Early_Load()
        { 
        #if (harmony)
            new Harmony(Instance.ModNameID).PatchAll();
        #endif
        }

        public override void Load()
        {
            
        }
    }    
}
#endif
#else
using System;
using System.Collections.Generic;
using HarmonyLib;
using ModLoader;

#if (fileScopedNamespace)
namespace generatedRootNamespace;

public class entrypointClassName : Mod
{
    public static entrypointClassName Instance { get; private set; }
    public entrypointClassName()
    {
        Instance = this;
    }
    
    public override string ModNameID => "generatedModNameId";
    public override string DisplayName => "generatedModDisplayName";
    public override string Author => "author";
    public override string MinimumGameVersionNecessary => "minimumGameVersion";
    public override string ModVersion => "modVersion";
    public override string Description => "modDescription";
    public override string IconLink => null;
    public override Action LoadKeybindings => null;

    public override Dictionary<string, string> Dependencies => new Dictionary<string, string>();
    
    public override void Early_Load()
    { 
        #if (harmony)
        new Harmony(Instance.ModNameID).PatchAll();
        #endif
    }

    public override void Load()
    {
        
    }
}    
#else
namespace generatedRootNamespace
{
    public class entrypointClassName : Mod
    {
        public static entrypointClassName Instance { get; private set; }
        public entrypointClassName()
        {
            Instance = this;
        }
        
        public override string ModNameID => "generatedModNameId";
        public override string DisplayName => "generatedModDisplayName";
        public override string Author => "author";
        public override string MinimumGameVersionNecessary => "minimumGameVersion";
        public override string ModVersion => "modVersion";
        public override string Description => "modDescription";
        public override string IconLink => null;
        public override Action LoadKeybindings => null;

        public override Dictionary<string, string> Dependencies => new Dictionary<string, string>();
        
        public override void Early_Load()
        { 
            #if (harmony)
            new Harmony(Instance.ModNameID).PatchAll();
            #endif
        }

        public override void Load()
        {
            
        }
    }    
}
#endif
#endif