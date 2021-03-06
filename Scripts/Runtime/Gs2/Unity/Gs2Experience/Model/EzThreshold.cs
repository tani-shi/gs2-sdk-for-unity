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
using Gs2.Gs2Experience.Model;
using System.Collections.Generic;
using System.Linq;
using LitJson;
using UnityEngine.Scripting;


namespace Gs2.Unity.Gs2Experience.Model
{
	[Preserve]
	[System.Serializable]
	public class EzThreshold
	{
		/** ランクアップ閾値のメタデータ */
		[UnityEngine.SerializeField]
		public string Metadata;
		/** ランクアップ経験値閾値リスト */
		[UnityEngine.SerializeField]
		public List<long> Values;

		public EzThreshold()
		{

		}

		public EzThreshold(Gs2.Gs2Experience.Model.Threshold @threshold)
		{
			Metadata = @threshold.metadata;
			Values = @threshold.values != null ? @threshold.values.Select(value =>
                {
                    if (value.HasValue)
                    {
                        return value.Value;
                    }
                    return 0;
                }
			).ToList() : new List<long>(new long[] {});
		}

        public virtual Threshold ToModel()
        {
            return new Threshold {
                metadata = Metadata,
                values = Values != null ? Values.Select(Value0 =>
                        {
                            return (long?)Value0;
                        }
                ).ToList() : new List<long?>(new long?[] {}),
            };
        }

        public virtual void WriteJson(JsonWriter writer)
        {
            writer.WriteObjectStart();
            if(this.Metadata != null)
            {
                writer.WritePropertyName("metadata");
                writer.Write(this.Metadata);
            }
            if(this.Values != null)
            {
                writer.WritePropertyName("values");
                writer.WriteArrayStart();
                foreach(var item in this.Values)
                {
                    writer.Write(item);
                }
                writer.WriteArrayEnd();
            }
            writer.WriteObjectEnd();
        }
	}
}
