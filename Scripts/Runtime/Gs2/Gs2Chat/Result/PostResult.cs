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
using Gs2.Gs2Chat.Model;
using LitJson;
using UnityEngine.Scripting;

namespace Gs2.Gs2Chat.Result
{
	[Preserve]
	public class PostResult
	{
        /** 投稿したメッセージ */
        public Message item { set; get; }


    	[Preserve]
        public static PostResult FromDict(JsonData data)
        {
            return new PostResult {
                item = data.Keys.Contains("item") && data["item"] != null ? Gs2.Gs2Chat.Model.Message.FromDict(data["item"]) : null,
            };
        }
	}
}