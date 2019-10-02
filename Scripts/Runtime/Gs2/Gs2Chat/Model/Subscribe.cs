/*
 * Copyright 2016 Game Server Services, Inc. or its affiliates. All Rights
 * Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://www.apache.org/licenses/LICENSE-2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using Gs2.Core.Model;
using LitJson;
using UnityEngine.Scripting;

namespace Gs2.Gs2Chat.Model
{
	[Preserve]
	public class Subscribe
	{

        /** 購読 */
        public string subscribeId { set; get; }

        /**
         * 購読を設定
         *
         * @param subscribeId 購読
         * @return this
         */
        public Subscribe WithSubscribeId(string subscribeId) {
            this.subscribeId = subscribeId;
            return this;
        }

        /** 購読するユーザID */
        public string userId { set; get; }

        /**
         * 購読するユーザIDを設定
         *
         * @param userId 購読するユーザID
         * @return this
         */
        public Subscribe WithUserId(string userId) {
            this.userId = userId;
            return this;
        }

        /** 購読するルーム名 */
        public string roomName { set; get; }

        /**
         * 購読するルーム名を設定
         *
         * @param roomName 購読するルーム名
         * @return this
         */
        public Subscribe WithRoomName(string roomName) {
            this.roomName = roomName;
            return this;
        }

        /** 新着メッセージ通知を受け取るカテゴリリスト */
        public List<NotificationType> notificationTypes { set; get; }

        /**
         * 新着メッセージ通知を受け取るカテゴリリストを設定
         *
         * @param notificationTypes 新着メッセージ通知を受け取るカテゴリリスト
         * @return this
         */
        public Subscribe WithNotificationTypes(List<NotificationType> notificationTypes) {
            this.notificationTypes = notificationTypes;
            return this;
        }

        /** 作成日時 */
        public long? createdAt { set; get; }

        /**
         * 作成日時を設定
         *
         * @param createdAt 作成日時
         * @return this
         */
        public Subscribe WithCreatedAt(long? createdAt) {
            this.createdAt = createdAt;
            return this;
        }

        public void WriteJson(JsonWriter writer)
        {
            writer.WriteObjectStart();
            if(this.subscribeId != null)
            {
                writer.WritePropertyName("subscribeId");
                writer.Write(this.subscribeId);
            }
            if(this.userId != null)
            {
                writer.WritePropertyName("userId");
                writer.Write(this.userId);
            }
            if(this.roomName != null)
            {
                writer.WritePropertyName("roomName");
                writer.Write(this.roomName);
            }
            if(this.notificationTypes != null)
            {
                writer.WritePropertyName("notificationTypes");
                writer.WriteArrayStart();
                foreach(var item in this.notificationTypes)
                {
                    item.WriteJson(writer);
                }
                writer.WriteArrayEnd();
            }
            if(this.createdAt.HasValue)
            {
                writer.WritePropertyName("createdAt");
                writer.Write(this.createdAt.Value);
            }
            writer.WriteObjectEnd();
        }

        public static Subscribe FromDict(JsonData data)
        {
            return new Subscribe()
                .WithSubscribeId(data.Keys.Contains("subscribeId") ? (string) data["subscribeId"] : null)
                .WithUserId(data.Keys.Contains("userId") ? (string) data["userId"] : null)
                .WithRoomName(data.Keys.Contains("roomName") ? (string) data["roomName"] : null)
                .WithNotificationTypes(data.Keys.Contains("notificationTypes") ? data["notificationTypes"].Cast<JsonData>().Select(value =>
                    {
                        return NotificationType.FromDict(value);
                    }
                ).ToList() : null)
                .WithCreatedAt(data.Keys.Contains("createdAt") ? (long?) data["createdAt"] : null);
        }
	}
}