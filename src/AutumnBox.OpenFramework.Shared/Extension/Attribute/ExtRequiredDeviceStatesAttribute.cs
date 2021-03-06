﻿/*************************************************
** auth： zsh2401@163.com
** date:  2018/8/1 20:45:49 (UTC +8:00)
** desc： ...
*************************************************/
using AutumnBox.Basic.Device;

namespace AutumnBox.OpenFramework.Extension
{
    /// <summary>
    /// 拓展模块运行所需的设备状态
    /// 秋之盒将确保只有设备符合该状态时才可以调用该模块
    /// </summary>
    public class ExtRequiredDeviceStatesAttribute : ExtensionInfoAttribute
    {
        /// <summary>
        /// 任何状态
        /// </summary>
        public const DeviceState ANY_STATE = AutumnBoxExtension.AllState;
        /// <summary>
        /// 无关状态
        /// </summary>
        public const DeviceState NO_MATTER = AutumnBoxExtension.NoMatter;

        /// <summary>
        /// 构造
        /// </summary>
        /// <param name="state"></param>
        public ExtRequiredDeviceStatesAttribute(DeviceState state = NO_MATTER) :
            base(ExtensionMetadataKeys.REQ_DEV_STATE, state)
        {
        }
    }
}
