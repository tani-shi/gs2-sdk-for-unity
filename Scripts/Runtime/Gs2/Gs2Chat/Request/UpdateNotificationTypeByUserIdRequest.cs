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
using Gs2.Core.Control;
using Gs2.Core.Model;
using Gs2.Gs2Chat.Model;
using LitJson;
using UnityEngine.Scripting;

namespace Gs2.Gs2Chat.Request
{
	[Preserve]
	public class UpdateNotificationTypeByUserIdRequest : Gs2Request<UpdateNotificationTypeByUserIdRequest>
	{

        /** ネームスペース名 */
        public string namespaceName { set; get; }

        /**
         * ネームスペース名を設定
         *
         * @param namespaceName ネームスペース名
         * @return this
         */
        public UpdateNotificationTypeByUserIdRequest WithNamespaceName(string namespaceName) {
            this.namespaceName = namespaceName;
            return this;
        }


        /** ルーム名 */
        public string roomName { set; get; }

        /**
         * ルーム名を設定
         *
         * @param roomName ルーム名
         * @return this
         */
        public UpdateNotificationTypeByUserIdRequest WithRoomName(string roomName) {
            this.roomName = roomName;
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
        public UpdateNotificationTypeByUserIdRequest WithUserId(string userId) {
            this.userId = userId;
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
        public UpdateNotificationTypeByUserIdRequest WithNotificationTypes(List<NotificationType> notificationTypes) {
            this.notificationTypes = notificationTypes;
            return this;
        }


        /** 重複実行回避機能に使用するID */
        public string duplicationAvoider { set; get; }

        /**
         * 重複実行回避機能に使用するIDを設定
         *
         * @param duplicationAvoider 重複実行回避機能に使用するID
         * @return this
         */
        public UpdateNotificationTypeByUserIdRequest WithDuplicationAvoider(string duplicationAvoider) {
            this.duplicationAvoider = duplicationAvoider;
            return this;
        }


    	[Preserve]
        public static UpdateNotificationTypeByUserIdRequest FromDict(JsonData data)
        {
            return new UpdateNotificationTypeByUserIdRequest {
                namespaceName = data.Keys.Contains("namespaceName") && data["namespaceName"] != null ? data["namespaceName"].ToString(): null,
                roomName = data.Keys.Contains("roomName") && data["roomName"] != null ? data["roomName"].ToString(): null,
                userId = data.Keys.Contains("userId") && data["userId"] != null ? data["userId"].ToString(): null,
                notificationTypes = data.Keys.Contains("notificationTypes") && data["notificationTypes"] != null ? data["notificationTypes"].Cast<JsonData>().Select(value =>
                    {
                        return Gs2.Gs2Chat.Model.NotificationType.FromDict(value);
                    }
                ).ToList() : null,
                duplicationAvoider = data.Keys.Contains("duplicationAvoider") && data["duplicationAvoider"] != null ? data["duplicationAvoider"].ToString(): null,
            };
        }

	}
}