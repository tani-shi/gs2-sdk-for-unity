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
using Gs2.Gs2Version.Model;
using LitJson;
using UnityEngine.Scripting;

namespace Gs2.Gs2Version.Result
{
	[Preserve]
	public class DescribeVersionModelMastersResult
	{
        /** バージョンマスターのリスト */
        public List<VersionModelMaster> items { set; get; }

        /** リストの続きを取得するためのページトークン */
        public string nextPageToken { set; get; }


    	[Preserve]
        public static DescribeVersionModelMastersResult FromDict(JsonData data)
        {
            return new DescribeVersionModelMastersResult {
                items = data.Keys.Contains("items") && data["items"] != null ? data["items"].Cast<JsonData>().Select(value =>
                    {
                        return Gs2.Gs2Version.Model.VersionModelMaster.FromDict(value);
                    }
                ).ToList() : null,
                nextPageToken = data.Keys.Contains("nextPageToken") && data["nextPageToken"] != null ? data["nextPageToken"].ToString() : null,
            };
        }
	}
}