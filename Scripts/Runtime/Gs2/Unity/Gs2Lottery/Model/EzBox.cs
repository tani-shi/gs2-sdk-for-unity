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
using Gs2.Gs2Lottery.Model;
using System.Collections.Generic;
using System.Linq;


namespace Gs2.Unity.Gs2Lottery.Model
{
	public class EzBox
	{
		/** 排出確率テーブル名 */
		public string PrizeTableName { get; set; }
		/** 排出済み景品のインデックスのリスト */
		public List<int> DrawnIndexes { get; set; }

		public EzBox()
		{

		}

		public EzBox(Gs2.Gs2Lottery.Model.Box @box)
		{
			PrizeTableName = @box.prizeTableName;
			DrawnIndexes = @box.drawnIndexes != null ? @box.drawnIndexes.Select(value =>
                {
                    if (value.HasValue)
                    {
                        return value.Value;
                    }
                    return 0;
                }
			).ToList() : new List<int>(new int[] {});
		}

        public Box ToModel()
        {
            return new Box {
                prizeTableName = PrizeTableName,
                drawnIndexes = DrawnIndexes != null ? DrawnIndexes.Select(Value0 =>
                        {
                            return (int?)Value0;
                        }
                ).ToList() : new List<int?>(new int?[] {}),
            };
        }
	}
}