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
	public class DrawByUserIdRequest : Gs2Request<DrawByUserIdRequest>
	{

        /** ネームスペース名 */
        public string namespaceName { set; get; }

        /**
         * ネームスペース名を設定
         *
         * @param namespaceName ネームスペース名
         * @return this
         */
        public DrawByUserIdRequest WithNamespaceName(string namespaceName) {
            this.namespaceName = namespaceName;
            return this;
        }


        /** 抽選モデルの種類名 */
        public string lotteryName { set; get; }

        /**
         * 抽選モデルの種類名を設定
         *
         * @param lotteryName 抽選モデルの種類名
         * @return this
         */
        public DrawByUserIdRequest WithLotteryName(string lotteryName) {
            this.lotteryName = lotteryName;
            return this;
        }


        /** ユーザーID */
        public string userId { set; get; }

        /**
         * ユーザーIDを設定
         *
         * @param userId ユーザーID
         * @return this
         */
        public DrawByUserIdRequest WithUserId(string userId) {
            this.userId = userId;
            return this;
        }


        /** 抽選回数 */
        public int? count { set; get; }

        /**
         * 抽選回数を設定
         *
         * @param count 抽選回数
         * @return this
         */
        public DrawByUserIdRequest WithCount(int? count) {
            this.count = count;
            return this;
        }


        /** スタンプシートのプレースホルダの適用する設定値 */
        public List<Config> config { set; get; }

        /**
         * スタンプシートのプレースホルダの適用する設定値を設定
         *
         * @param config スタンプシートのプレースホルダの適用する設定値
         * @return this
         */
        public DrawByUserIdRequest WithConfig(List<Config> config) {
            this.config = config;
            return this;
        }


        /** 重複実行回避機能に使用するID */
        public string duplicationAvoider { set; get; }

        /**
         * 重複実行回避機能に使用するIDを設定
         *
         * @param duplicationAvoider 重複実行回避機能に使用するID
         * @return this
         */
        public DrawByUserIdRequest WithDuplicationAvoider(string duplicationAvoider) {
            this.duplicationAvoider = duplicationAvoider;
            return this;
        }


    	[Preserve]
        public static DrawByUserIdRequest FromDict(JsonData data)
        {
            return new DrawByUserIdRequest {
                namespaceName = data.Keys.Contains("namespaceName") && data["namespaceName"] != null ? data["namespaceName"].ToString(): null,
                lotteryName = data.Keys.Contains("lotteryName") && data["lotteryName"] != null ? data["lotteryName"].ToString(): null,
                userId = data.Keys.Contains("userId") && data["userId"] != null ? data["userId"].ToString(): null,
                count = data.Keys.Contains("count") && data["count"] != null ? (int?)int.Parse(data["count"].ToString()) : null,
                config = data.Keys.Contains("config") && data["config"] != null ? data["config"].Cast<JsonData>().Select(value =>
                    {
                        return Gs2.Gs2Lottery.Model.Config.FromDict(value);
                    }
                ).ToList() : null,
                duplicationAvoider = data.Keys.Contains("duplicationAvoider") && data["duplicationAvoider"] != null ? data["duplicationAvoider"].ToString(): null,
            };
        }

	}
}