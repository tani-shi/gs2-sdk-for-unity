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
using Gs2.Core.Model;
using Gs2.Unity.Gs2Experience.Model;
using Gs2.Gs2Experience.Result;
using UnityEngine.Scripting;

namespace Gs2.Unity.Gs2Experience.Result
{
	[Preserve]
	public class EzListExperienceModelsResult
	{
        /** 経験値・ランクアップ閾値モデルのリスト */
        public List<EzExperienceModel> Items { get; private set; }


        public EzListExperienceModelsResult(
            DescribeExperienceModelsResult result
        )
        {
            Items = new List<EzExperienceModel>();
            foreach (var item_ in result.items)
            {
                Items.Add(new EzExperienceModel(item_));
            }
        }
	}
}