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
using Gs2.Gs2Friend.Model;
using LitJson;
using UnityEngine.Scripting;

namespace Gs2.Gs2Friend.Result
{
	[Preserve]
	public class UpdateNamespaceResult
	{
        /** 更新したネームスペース */
        public Namespace item { set; get; }


    	[Preserve]
        public static UpdateNamespaceResult FromDict(JsonData data)
        {
            return new UpdateNamespaceResult {
                item = data.Keys.Contains("item") && data["item"] != null ? Gs2.Gs2Friend.Model.Namespace.FromDict(data["item"]) : null,
            };
        }
	}
}