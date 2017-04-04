using System;

namespace AIRCRM.MODEL
{
    /// <summary>
    /// 菜单模块
    /// </summary>
    [Serializable]
    public class CRM_Menu
    {
        /// <summary>
        /// 菜单编号
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 菜单GUID
        /// </summary>
        public System.Guid MenuGUID { get; set; }
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string MenuName { get; set; }
        /// <summary>
        /// 菜单标题
        /// </summary>
        public string MenuItemCaption { get; set; }
        /// <summary>
        /// 菜单项英文标题
        /// </summary>
        public string MenuItemCaptionEnglish { get; set; }
        /// <summary>
        /// 是否为父级菜单
        /// </summary>
        public bool IsParentMenuItem { get; set; }
        /// <summary>
        /// 菜单图标
        /// </summary>
        public string MenuItemICON { get; set; }
        /// <summary>
        /// 菜单项状态(0:启用，1：禁用)
        /// </summary>
        public Nullable<bool> MenuItemStatus { get; set; }
        /// <summary>
        /// 菜单项URL
        /// </summary>
        public string MenuItemUrl { get; set; }
        /// <summary>
        /// 菜单项类型
        /// </summary>
        public string MenuItemType { get; set; }
        /// <summary>
        /// 菜单项父菜单GUID
        /// </summary>
        public Nullable<System.Guid> MenuParentGUID { get; set; }
    }
}
