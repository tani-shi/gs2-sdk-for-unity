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
using Gs2.Gs2News.Model;
using LitJson;
using UnityEngine.Scripting;

namespace Gs2.Gs2News.Request
{
	[Preserve]
	public class UpdateCurrentNewsMasterRequest : Gs2Request<UpdateCurrentNewsMasterRequest>
	{

        /** ネームスペースの名前 */
        public string namespaceName { set; get; }

        /**
         * ネームスペースの名前を設定
         *
         * @param namespaceName ネームスペースの名前
         * @return this
         */
        public UpdateCurrentNewsMasterRequest WithNamespaceName(string namespaceName) {
            this.namespaceName = namespaceName;
            return this;
        }


        /** アップロード準備で受け取ったトークン */
        public string uploadToken { set; get; }

        /**
         * アップロード準備で受け取ったトークンを設定
         *
         * @param uploadToken アップロード準備で受け取ったトークン
         * @return this
         */
        public UpdateCurrentNewsMasterRequest WithUploadToken(string uploadToken) {
            this.uploadToken = uploadToken;
            return this;
        }


    	[Preserve]
        public static UpdateCurrentNewsMasterRequest FromDict(JsonData data)
        {
            return new UpdateCurrentNewsMasterRequest {
                namespaceName = data.Keys.Contains("namespaceName") && data["namespaceName"] != null ? data["namespaceName"].ToString(): null,
                uploadToken = data.Keys.Contains("uploadToken") && data["uploadToken"] != null ? data["uploadToken"].ToString(): null,
            };
        }

	}
}