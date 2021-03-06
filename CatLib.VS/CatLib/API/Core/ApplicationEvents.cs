﻿/*
 * This file is part of the CatLib package.
 *
 * (c) Yu Bin <support@catlib.io>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Document: http://catlib.io/
 */

namespace CatLib.API
{
    /// <summary>
    /// 应用程序事件
    /// </summary>
    public sealed class ApplicationEvents
    {
        /// <summary>
        /// 当程序启动完成
        /// </summary>
        public static readonly string OnStartComplete = "catlib.application.start.complete";

        /// <summary>
        /// 当释放之前
        /// </summary>
        public static readonly string OnBeforeDestroy = "catlib.application.destroy.before";

        /// <summary>
        /// 当释放完成后
        /// </summary>
        public static readonly string OnDestroyed = "catlib.application.destroyed";
    }
}