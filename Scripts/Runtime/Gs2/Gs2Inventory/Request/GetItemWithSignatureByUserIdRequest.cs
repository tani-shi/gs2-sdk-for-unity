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
using Gs2.Gs2Inventory.Model;
using LitJson;
using UnityEngine.Scripting;

namespace Gs2.Gs2Inventory.Request
{
	[Preserve]
	public class GetItemWithSignatureByUserIdRequest : Gs2Request<GetItemWithSignatureByUserIdRequest>
	{

        /** ネームスペース名 */
        public string namespaceName { set; get; }

        /**
         * ネームスペース名を設定
         *
         * @param namespaceName ネームスペース名
         * @return this
         */
        public GetItemWithSignatureByUserIdRequest WithNamespaceName(string namespaceName) {
            this.namespaceName = namespaceName;
            return this;
        }


        /** インベントリの名前 */
        public string inventoryName { set; get; }

        /**
         * インベントリの名前を設定
         *
         * @param inventoryName インベントリの名前
         * @return this
         */
        public GetItemWithSignatureByUserIdRequest WithInventoryName(string inventoryName) {
            this.inventoryName = inventoryName;
            return this;
        }


        /** ユーザーID */
        public string userId { set; get; }

        /**
         * ユーザーIDを設定
         *
         * @param userId ユーザーID
         * @return this
         */
        public GetItemWithSignatureByUserIdRequest WithUserId(string userId) {
            this.userId = userId;
            return this;
        }


        /** アイテムマスターの名前 */
        public string itemName { set; get; }

        /**
         * アイテムマスターの名前を設定
         *
         * @param itemName アイテムマスターの名前
         * @return this
         */
        public GetItemWithSignatureByUserIdRequest WithItemName(string itemName) {
            this.itemName = itemName;
            return this;
        }


        /** アイテムセットを識別する名前 */
        public string itemSetName { set; get; }

        /**
         * アイテムセットを識別する名前を設定
         *
         * @param itemSetName アイテムセットを識別する名前
         * @return this
         */
        public GetItemWithSignatureByUserIdRequest WithItemSetName(string itemSetName) {
            this.itemSetName = itemSetName;
            return this;
        }


        /** 署名の発行に使用する暗号鍵 のGRN */
        public string keyId { set; get; }

        /**
         * 署名の発行に使用する暗号鍵 のGRNを設定
         *
         * @param keyId 署名の発行に使用する暗号鍵 のGRN
         * @return this
         */
        public GetItemWithSignatureByUserIdRequest WithKeyId(string keyId) {
            this.keyId = keyId;
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
        public GetItemWithSignatureByUserIdRequest WithDuplicationAvoider(string duplicationAvoider) {
            this.duplicationAvoider = duplicationAvoider;
            return this;
        }


    	[Preserve]
        public static GetItemWithSignatureByUserIdRequest FromDict(JsonData data)
        {
            return new GetItemWithSignatureByUserIdRequest {
                namespaceName = data.Keys.Contains("namespaceName") && data["namespaceName"] != null ? data["namespaceName"].ToString(): null,
                inventoryName = data.Keys.Contains("inventoryName") && data["inventoryName"] != null ? data["inventoryName"].ToString(): null,
                userId = data.Keys.Contains("userId") && data["userId"] != null ? data["userId"].ToString(): null,
                itemName = data.Keys.Contains("itemName") && data["itemName"] != null ? data["itemName"].ToString(): null,
                itemSetName = data.Keys.Contains("itemSetName") && data["itemSetName"] != null ? data["itemSetName"].ToString(): null,
                keyId = data.Keys.Contains("keyId") && data["keyId"] != null ? data["keyId"].ToString(): null,
                duplicationAvoider = data.Keys.Contains("duplicationAvoider") && data["duplicationAvoider"] != null ? data["duplicationAvoider"].ToString(): null,
            };
        }

	}
}