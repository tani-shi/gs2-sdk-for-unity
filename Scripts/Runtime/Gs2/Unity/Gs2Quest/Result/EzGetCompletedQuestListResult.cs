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
using Gs2.Unity.Gs2Quest.Model;
using Gs2.Gs2Quest.Result;
using UnityEngine.Scripting;

namespace Gs2.Unity.Gs2Quest.Result
{
	[Preserve]
	public class EzGetCompletedQuestListResult
	{
        /** クエスト進行 */
        public EzCompletedQuestList Item { get; private set; }


        public EzGetCompletedQuestListResult(
            GetCompletedQuestListResult result
        )
        {
            if(result.item != null)
            {
                Item = new EzCompletedQuestList(result.item);
            }
        }
	}
}