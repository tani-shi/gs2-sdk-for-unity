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
using Gs2.Gs2Datastore.Model;
using LitJson;
using UnityEngine.Scripting;

namespace Gs2.Gs2Datastore.Request
{
	[Preserve]
	public class PrepareDownloadByGenerationRequest : Gs2Request<PrepareDownloadByGenerationRequest>
	{

        /** ネームスペース名 */
        public string namespaceName { set; get; }

        /**
         * ネームスペース名を設定
         *
         * @param namespaceName ネームスペース名
         * @return this
         */
        public PrepareDownloadByGenerationRequest WithNamespaceName(string namespaceName) {
            this.namespaceName = namespaceName;
            return this;
        }


        /** データの名前 */
        public string dataObjectName { set; get; }

        /**
         * データの名前を設定
         *
         * @param dataObjectName データの名前
         * @return this
         */
        public PrepareDownloadByGenerationRequest WithDataObjectName(string dataObjectName) {
            this.dataObjectName = dataObjectName;
            return this;
        }


        /** 世代 */
        public string generation { set; get; }

        /**
         * 世代を設定
         *
         * @param generation 世代
         * @return this
         */
        public PrepareDownloadByGenerationRequest WithGeneration(string generation) {
            this.generation = generation;
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
        public PrepareDownloadByGenerationRequest WithDuplicationAvoider(string duplicationAvoider) {
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
        public PrepareDownloadByGenerationRequest WithAccessToken(string accessToken) {
            this.accessToken = accessToken;
            return this;
        }

    	[Preserve]
        public static PrepareDownloadByGenerationRequest FromDict(JsonData data)
        {
            return new PrepareDownloadByGenerationRequest {
                namespaceName = data.Keys.Contains("namespaceName") && data["namespaceName"] != null ? data["namespaceName"].ToString(): null,
                dataObjectName = data.Keys.Contains("dataObjectName") && data["dataObjectName"] != null ? data["dataObjectName"].ToString(): null,
                generation = data.Keys.Contains("generation") && data["generation"] != null ? data["generation"].ToString(): null,
                duplicationAvoider = data.Keys.Contains("duplicationAvoider") && data["duplicationAvoider"] != null ? data["duplicationAvoider"].ToString(): null,
            };
        }

	}
}