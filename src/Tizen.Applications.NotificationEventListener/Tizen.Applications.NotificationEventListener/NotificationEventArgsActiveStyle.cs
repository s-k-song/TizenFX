/*
 * Copyright (c) 2017 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace Tizen.Applications.NotificationEventListener
{
    using System.Collections.Generic;

    /// <summary>
    ///  Class for generating Active style notification
    /// </summary>
    public partial class NotificationEventArgs
    {
        public class ActiveStyleArgs : StyleArgs
        {
            /// <summary>
            /// Constructor
            /// </summary>
            public ActiveStyleArgs()
            {
                Button = new List<ButtonActionArgs>();
            }

            /// <summary>
            /// Gets the IsAutoRemove option of the active notification.
            /// IsAutoRemove option lets the active notification be removed several seconds after it shows.
            /// </summary>
            /// <value>
            /// When 'IsAutoRemove' is set as false, the active notification will not be removed as long as the user removes
            /// the active notification or the app which posted the active notification removes the active notification.
            /// </value>
            /// <example>
            /// <code>
            /// NotificationEventArgs.ActiveStyleArgs style = NotificationEventArgs.GetStyle<NotificationEventArgs.ActiveStyleArgs>();
            /// bool isAutoRemove = style.IsAutoRemove;
            /// </code>
            /// </example>
            public bool IsAutoRemove { get; internal set; }

            /// <summary>
            /// Gets an absolute path for an image file to display on the background of active notification.
            /// </summary>
            /// <example>
            /// <code>
            /// NotificationEventArgs.ActiveStyleArgs style = NotificationEventArgs.GetStyle<NotificationEventArgs.ActiveStyleArgs>();
            /// string path = style.BackgroundImage;
            /// </code>
            /// </example>
            public string BackgroundImage { get; internal set; }

            /// <summary>
            /// Gets timeout value in second when the notification can be hidden from the viewer.
            /// </summary>
            /// <example>
            /// <code>
            /// NotificationEventArgs.ActiveStyleArgs style = NotificationEventArgs.GetStyle<NotificationEventArgs.ActiveStyleArgs>();
            /// int hideTimeout = style.HideTimeout;
            /// </code>
            /// </example>
            public int HideTimeout { get; internal set; }

            /// <summary>
            /// Gets timeout value in second when the notification can be deleted from the viewer.
            /// </summary>
            /// <example>
            /// <code>
            /// NotificationEventArgs.ActiveStyleArgs style = NotificationEventArgs.GetStyle<NotificationEventArgs.ActiveStyleArgs>();
            /// int deleteTimeout = style.DeleteTimeout;
            /// </code>
            /// </example>
            public int DeleteTimeout { get; internal set; }

            /// <summary>
            /// Gets a button to this active notification style.
            /// Buttons are displayed in the notification content.
            /// </summary>
            /// <example>
            /// <code>
            /// IList<ButtonActionArgs> button = NotificationEventArgs.ActiveStyleArgs.Button;
            /// </code>
            /// </example>
            public IList<ButtonActionArgs> Button { get; internal set; }

            /// <summary>
            /// Gets a button to this active notification style.
            /// Buttons are displayed in the notification content.
            /// </summary>
            /// <example>
            /// <code>
            /// NotificationEventArgs.ActiveStyleArgs style = NotificationEventArgs.GetStyle<NotificationEventArgs.ActiveStyleArgs>();
            /// ReplyActionArgs reply = style.Replay;
            /// </code>
            /// </example>
            public ReplyActionArgs Reply { get; internal set; }

            internal override string Key
            {
                get
                {
                    return "Active";
                }
            }
        }
    }
}
