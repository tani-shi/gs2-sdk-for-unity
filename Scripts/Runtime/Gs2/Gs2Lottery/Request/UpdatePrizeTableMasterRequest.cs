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
using Gs2.Gs2Lottery.Model;
using LitJson;
using UnityEngine.Scripting;

namespace Gs2.Gs2Lottery.Request
{
	[Preserve]
	public class UpdatePrizeTableMasterRequest : Gs2Request<UpdatePrizeTableMasterRequest>
	{

        /** ネームスペース名 */
        public string namespaceName { set; get; }

        /**
         * ネームスペース名を設定
         *
         * @param namespaceName ネームスペース名
         * @return this
         */
        public UpdatePrizeTableMasterRequest WithNamespaceName(string namespaceName) {
            this.namespaceName = namespaceName;
            return this;
        }


        /** 排出確率テーブル名 */
        public string prizeTableName { set; get; }

        /**
         * 排出確率テーブル名を設定
         *
         * @param prizeTableName 排出確率テーブル名
         * @return this
         */
        public UpdatePrizeTableMasterRequest WithPrizeTableName(string prizeTableName) {
            this.prizeTableName = prizeTableName;
            return this;
        }


        /** 排出確率テーブルマスターの説明 */
        public string description { set; get; }

        /**
         * 排出確率テーブルマスターの説明を設定
         *
         * @param description 排出確率テーブルマスターの説明
         * @return this
         */
        public UpdatePrizeTableMasterRequest WithDescription(string description) {
            this.description = description;
            return this;
        }


        /** 排出確率テーブルのメタデータ */
        public string metadata { set; get; }

        /**
         * 排出確率テーブルのメタデータを設定
         *
         * @param metadata 排出確率テーブルのメタデータ
         * @return this
         */
        public UpdatePrizeTableMasterRequest WithMetadata(string metadata) {
            this.metadata = metadata;
            return this;
        }


        /** 景品リスト */
        public List<Prize> prizes { set; get; }

        /**
         * 景品リストを設定
         *
         * @param prizes 景品リスト
         * @return this
         */
        public UpdatePrizeTableMasterRequest WithPrizes(List<Prize> prizes) {
            this.prizes = prizes;
            return this;
        }


    	[Preserve]
        public static UpdatePrizeTableMasterRequest FromDict(JsonData data)
        {
            return new UpdatePrizeTableMasterRequest {
                namespaceName = data.Keys.Contains("namespaceName") && data["namespaceName"] != null ? data["namespaceName"].ToString(): null,
                prizeTableName = data.Keys.Contains("prizeTableName") && data["prizeTableName"] != null ? data["prizeTableName"].ToString(): null,
                description = data.Keys.Contains("description") && data["description"] != null ? data["description"].ToString(): null,
                metadata = data.Keys.Contains("metadata") && data["metadata"] != null ? data["metadata"].ToString(): null,
                prizes = data.Keys.Contains("prizes") && data["prizes"] != null ? data["prizes"].Cast<JsonData>().Select(value =>
                    {
                        return Gs2.Gs2Lottery.Model.Prize.FromDict(value);
                    }
                ).ToList() : null,
            };
        }

	}
}