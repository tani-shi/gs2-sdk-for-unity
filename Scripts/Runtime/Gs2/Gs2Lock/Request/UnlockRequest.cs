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
using Gs2.Gs2Lock.Model;
using LitJson;
using UnityEngine.Scripting;

namespace Gs2.Gs2Lock.Request
{
	[Preserve]
	public class UnlockRequest : Gs2Request<UnlockRequest>
	{

        /** カテゴリー名 */
        public string namespaceName { set; get; }

        /**
         * カテゴリー名を設定
         *
         * @param namespaceName カテゴリー名
         * @return this
         */
        public UnlockRequest WithNamespaceName(string namespaceName) {
            this.namespaceName = namespaceName;
            return this;
        }


        /** プロパティID */
        public string propertyId { set; get; }

        /**
         * プロパティIDを設定
         *
         * @param propertyId プロパティID
         * @return this
         */
        public UnlockRequest WithPropertyId(string propertyId) {
            this.propertyId = propertyId;
            return this;
        }


        /** ロックを取得したトランザクションID */
        public string transactionId { set; get; }

        /**
         * ロックを取得したトランザクションIDを設定
         *
         * @param transactionId ロックを取得したトランザクションID
         * @return this
         */
        public UnlockRequest WithTransactionId(string transactionId) {
            this.transactionId = transactionId;
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
        public UnlockRequest WithDuplicationAvoider(string duplicationAvoider) {
            this.duplicationAvoider = duplicationAvoider;
            return this;
        }


        /** アクセストークン */
        public string accessToken { set; get; }

        /**
         * アクセストークンを設定
         *
         * @param accessToken アクセストークン
         * @return this
         */
        public UnlockRequest WithAccessToken(string accessToken) {
            this.accessToken = accessToken;
            return this;
        }

    	[Preserve]
        public static UnlockRequest FromDict(JsonData data)
        {
            return new UnlockRequest {
                namespaceName = data.Keys.Contains("namespaceName") && data["namespaceName"] != null ? data["namespaceName"].ToString(): null,
                propertyId = data.Keys.Contains("propertyId") && data["propertyId"] != null ? data["propertyId"].ToString(): null,
                transactionId = data.Keys.Contains("transactionId") && data["transactionId"] != null ? data["transactionId"].ToString(): null,
                duplicationAvoider = data.Keys.Contains("duplicationAvoider") && data["duplicationAvoider"] != null ? data["duplicationAvoider"].ToString(): null,
            };
        }

	}
}