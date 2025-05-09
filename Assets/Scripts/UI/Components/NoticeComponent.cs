using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using BanpoFri;
using UnityEngine.U2D;
public class NoticeComponent : MonoBehaviour
{
    public enum NoticeType
    {
        None,
        Seaweed,
        Nap,
        Break,
    }

    [SerializeField]
    private Button NoticeBtn;

    [SerializeField]
    private Image NoticeImg;

    public NoticeType CurType = NoticeType.None;

    private Transform Target;

    void Awake()
    {
        NoticeBtn.onClick.AddListener(OnClickNotice);
    }

    public void Set(NoticeType type, Transform target)
    {
        CurType = type;

        Target = target;

    
        NoticeImg.sprite = AtlasManager.Instance.GetSprite(Atlas.Atals_UI_PopupImg,$"Icon_Noti_{type.ToString()}");

    }

    public void OnClickNotice()
    {
        GameRoot.Instance.InGameSystem.CurInGame.IngameCamera.FoucsPosition(Target.transform);
    }

}
