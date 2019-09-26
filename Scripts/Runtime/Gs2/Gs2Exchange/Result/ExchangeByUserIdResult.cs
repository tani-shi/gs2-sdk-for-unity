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
using Gs2.Gs2Exchange.Model;

namespace Gs2.Gs2Exchange.Result
{
	public class ExchangeByUserIdResult
	{
        /** 交換レートモデル */
        public RateModel item { set; get; }

        /** 交換処理の実行に使用するスタンプシート */
        public string stampSheet { set; get; }

	}
}