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
	public class DeleteRoomFromBackendRequest : Gs2Request<DeleteRoomFromBackendRequest>
	{

        /** ネームスペース名 */
        public string namespaceName { set; get; }

        /**
         * ネームスペース名を設定
         *
         * @param namespaceName ネームスペース名
         * @return this
         */
        public DeleteRoomFromBackendRequest WithNamespaceName(string namespaceName) {
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
        public DeleteRoomFromBackendRequest WithRoomName(string roomName) {
            this.roomName = roomName;
            return this;
        }


        /** ユーザID */
        public string userId { set; get; }

        /**
         * ユーザIDを設定
         *
         * @param userId ユーザID
         * @return this
         */
        public DeleteRoomFromBackendRequest WithUserId(string userId) {
            this.userId = userId;
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
        public DeleteRoomFromBackendRequest WithDuplicationAvoider(string duplicationAvoider) {
            this.duplicationAvoider = duplicationAvoider;
            return this;
        }


    	[Preserve]
        public static DeleteRoomFromBackendRequest FromDict(JsonData data)
        {
            return new DeleteRoomFromBackendRequest {
                namespaceName = data.Keys.Contains("namespaceName") && data["namespaceName"] != null ? data["namespaceName"].ToString(): null,
                roomName = data.Keys.Contains("roomName") && data["roomName"] != null ? data["roomName"].ToString(): null,
                userId = data.Keys.Contains("userId") && data["userId"] != null ? data["userId"].ToString(): null,
                duplicationAvoider = data.Keys.Contains("duplicationAvoider") && data["duplicationAvoider"] != null ? data["duplicationAvoider"].ToString(): null,
            };
        }

	}
}