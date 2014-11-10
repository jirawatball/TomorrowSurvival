using UnityEngine;
using System.IO;
#if UNITY_EDITOR
using UnityEditor;

[InitializeOnLoad]
#endif
public class SoundSetting : ScriptableObject
{
    #region Patt
    private const string SoundSettingAssetName = "SoundSetting";
    private const string SoundSettingPath = "LineMoveEditor/Resources";
    private const string SoundSettingAssetExtension = ".asset";
    private static SoundSetting Instance;

    private static SoundSetting GetInstance
    {
        get
        {
            if (Instance == null)
            {
                Instance = Resources.Load(SoundSettingAssetName) as SoundSetting;
                if (Instance == null)
                {
                    Instance = CreateInstance<SoundSetting>();
#if UNITY_EDITOR
                    string ProperPath = Path.Combine(Application.dataPath, SoundSettingPath);
                    if (!Directory.Exists(ProperPath))
                    {
                        AssetDatabase.CreateFolder("Assets/LineMoveEditor", "Resources");
                    }
                    string FullPath = Path.Combine(Path.Combine("Assets", SoundSettingPath), SoundSettingAssetName + SoundSettingAssetExtension);
                    AssetDatabase.CreateAsset(Instance, FullPath);
#endif
                }
            }
            return Instance;
        }
    }

    private static void DirtyEditor()
    {
#if UNITY_EDITOR
        EditorUtility.SetDirty(Instance);
#endif
    }

#if UNITY_EDITOR
    [MenuItem("LineMoveEditor/Setting/SoundSetting", false, 10)]
    public static void Edit()
    {
        Selection.activeObject = GetInstance;
    }
#endif
    #endregion

    #region Prop
    [SerializeField]
    private AudioClip[] _BGM = new[] { new AudioClip() };
    [SerializeField]
    private AudioClip _ButtonClick;
    [SerializeField]
    private AudioClip _UIActive;
    [SerializeField]
    private AudioClip _StageWin;
    [SerializeField]
    private AudioClip _StageWinStar;
    [SerializeField]
    private AudioClip _StageLose;
    [SerializeField]
    private AudioClip _LineDrag;
    [SerializeField]
    private AudioClip _LineCreate;
    [SerializeField]
    private AudioClip _LineCut;
    [SerializeField]
    private AudioClip _Star;
    [SerializeField]
    private AudioClip _Collection;
    [SerializeField]
    private AudioClip _Damage0;
    [SerializeField]
    private AudioClip _Damage1;
    [SerializeField]
    private AudioClip _Damage2;
    [SerializeField]
    private AudioClip _DamageOver;
    #endregion

    #region Editor
    public void SetBGM(int Index, AudioClip Value)
    {
        if (_BGM[Index] != Value)
        {
            _BGM[Index] = Value;
            DirtyEditor();
        }
    }
    public AudioClip[] BGM
    {
        get { return _BGM; }
        set
        {
            if (_BGM != value)
            {
                _BGM = value;
                DirtyEditor();
            }
        }
    }
    public AudioClip ButtonClick
    {
        get { return _ButtonClick; }
        set
        {
            if (_ButtonClick != value)
            {
                _ButtonClick = value;
                DirtyEditor();
            }
        }
    }
    public AudioClip UIActive
    {
        get { return _UIActive; }
        set
        {
            if (_UIActive != value)
            {
                _UIActive = value;
                DirtyEditor();
            }
        }
    }
    public AudioClip StageWin
    {
        get { return _StageWin; }
        set
        {
            if (_StageWin != value)
            {
                _StageWin = value;
                DirtyEditor();
            }
        }
    }
    public AudioClip StageWinStar
    {
        get { return _StageWinStar; }
        set
        {
            if (_StageWinStar != value)
            {
                _StageWinStar = value;
                DirtyEditor();
            }
        }
    }
    public AudioClip StageLose
    {
        get { return _StageLose; }
        set
        {
            if (_StageLose != value)
            {
                _StageLose = value;
                DirtyEditor();
            }
        }
    }
    public AudioClip LineDrag
    {
        get { return _LineDrag; }
        set
        {
            if (_LineDrag != value)
            {
                _LineDrag = value;
                DirtyEditor();
            }
        }
    }
    public AudioClip LineCreate
    {
        get { return _LineCreate; }
        set
        {
            if (_LineCreate != value)
            {
                _LineCreate = value;
                DirtyEditor();
            }
        }
    }
    public AudioClip LineCut
    {
        get { return _LineCut; }
        set
        {
            if (_LineCut != value)
            {
                _LineCut = value;
                DirtyEditor();
            }
        }
    }
    public AudioClip Star
    {
        get { return _Star; }
        set
        {
            if (_Star != value)
            {
                _Star = value;
                DirtyEditor();
            }
        }
    }
    public AudioClip Collection
    {
        get { return _Collection; }
        set
        {
            if (_Collection != value)
            {
                _Collection = value;
                DirtyEditor();
            }
        }
    }
    public AudioClip Damage0
    {
        get { return _Damage0; }
        set
        {
            if (_Damage0 != value)
            {
                _Damage0 = value;
                DirtyEditor();
            }
        }
    }
    public AudioClip Damage1
    {
        get { return _Damage1; }
        set
        {
            if (_Damage1 != value)
            {
                _Damage1 = value;
                DirtyEditor();
            }
        }
    }
    public AudioClip Damage2
    {
        get { return _Damage2; }
        set
        {
            if (_Damage2 != value)
            {
                _Damage2 = value;
                DirtyEditor();
            }
        }
    }
    public AudioClip DamageOver
    {
        get { return _DamageOver; }
        set
        {
            if (_DamageOver != value)
            {
                _DamageOver = value;
                DirtyEditor();
            }
        }
    }
    #endregion

    #region Getting
    public static AudioClip[] GetBGM { get { return GetInstance._BGM; } }
    public static AudioClip GetButtonClick { get { return GetInstance._ButtonClick; } }
    public static AudioClip GetUIActive { get { return GetInstance._UIActive; } }
    public static AudioClip GetStageWin { get { return GetInstance._StageWin; } }
    public static AudioClip GetStageWinStar { get { return GetInstance._StageWinStar; } }
    public static AudioClip GetStageLose { get { return GetInstance._StageLose; } }
    public static AudioClip GetLineDrag { get { return GetInstance._LineDrag; } }
    public static AudioClip GetLineCreate { get { return GetInstance._LineCreate; } }
    public static AudioClip GetLineCut { get { return GetInstance._LineCut; } }
    public static AudioClip GetStar { get { return GetInstance._Star; } }
    public static AudioClip GetCollection { get { return GetInstance._Collection; } }
    public static AudioClip GetDamage0 { get { return GetInstance._Damage0; } }
    public static AudioClip GetDamage1 { get { return GetInstance._Damage1; } }
    public static AudioClip GetDamage2 { get { return GetInstance._Damage2; } }
    public static AudioClip GetDamageOver { get { return GetInstance._DamageOver; } }
    #endregion


}
