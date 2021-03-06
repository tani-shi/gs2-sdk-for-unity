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
using Gs2.Gs2Account.Model;
using LitJson;
using UnityEngine.Scripting;

namespace Gs2.Gs2Account.Result
{
	[Preserve]
	public class AuthenticationResult
	{
        /** ゲームプレイヤーアカウント */
        public Account item { set; get; }

        /** 署名対象のアカウント情報 */
        public string body { set; get; }

        /** 署名 */
        public string signature { set; get; }


    	[Preserve]
        public static AuthenticationResult FromDict(JsonData data)
        {
            return new AuthenticationResult {
                item = data.Keys.Contains("item") && data["item"] != null ? Gs2.Gs2Account.Model.Account.FromDict(data["item"]) : null,
                body = data.Keys.Contains("body") && data["body"] != null ? data["body"].ToString() : null,
                signature = data.Keys.Contains("signature") && data["signature"] != null ? data["signature"].ToString() : null,
            };
        }
	}
}