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
using Gs2.Gs2Money.Model;
using LitJson;
using UnityEngine.Scripting;

namespace Gs2.Gs2Money.Request
{
	[Preserve]
	public class GetByUserIdAndTransactionIdRequest : Gs2Request<GetByUserIdAndTransactionIdRequest>
	{

        /** ネームスペースの名前 */
        public string namespaceName { set; get; }

        /**
         * ネームスペースの名前を設定
         *
         * @param namespaceName ネームスペースの名前
         * @return this
         */
        public GetByUserIdAndTransactionIdRequest WithNamespaceName(string namespaceName) {
            this.namespaceName = namespaceName;
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
        public GetByUserIdAndTransactionIdRequest WithUserId(string userId) {
            this.userId = userId;
            return this;
        }


        /** トランザクションID */
        public string transactionId { set; get; }

        /**
         * トランザクションIDを設定
         *
         * @param transactionId トランザクションID
         * @return this
         */
        public GetByUserIdAndTransactionIdRequest WithTransactionId(string transactionId) {
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
        public GetByUserIdAndTransactionIdRequest WithDuplicationAvoider(string duplicationAvoider) {
            this.duplicationAvoider = duplicationAvoider;
            return this;
        }


    	[Preserve]
        public static GetByUserIdAndTransactionIdRequest FromDict(JsonData data)
        {
            return new GetByUserIdAndTransactionIdRequest {
                namespaceName = data.Keys.Contains("namespaceName") && data["namespaceName"] != null ? data["namespaceName"].ToString(): null,
                userId = data.Keys.Contains("userId") && data["userId"] != null ? data["userId"].ToString(): null,
                transactionId = data.Keys.Contains("transactionId") && data["transactionId"] != null ? data["transactionId"].ToString(): null,
                duplicationAvoider = data.Keys.Contains("duplicationAvoider") && data["duplicationAvoider"] != null ? data["duplicationAvoider"].ToString(): null,
            };
        }

	}
}