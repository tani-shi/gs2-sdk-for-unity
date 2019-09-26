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
using Gs2.Core.Control;
using Gs2.Core.Model;
using Gs2.Gs2Inbox.Model;

namespace Gs2.Gs2Inbox.Request
{
	public class ReadMessageByUserIdRequest : Gs2Request<ReadMessageByUserIdRequest>
	{

        /** プレゼントボックス名 */
        public string namespaceName { set; get; }

        /**
         * プレゼントボックス名を設定
         *
         * @param namespaceName プレゼントボックス名
         * @return this
         */
        public ReadMessageByUserIdRequest WithNamespaceName(string namespaceName) {
            this.namespaceName = namespaceName;
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
        public ReadMessageByUserIdRequest WithUserId(string userId) {
            this.userId = userId;
            return this;
        }


        /** メッセージID */
        public string messageName { set; get; }

        /**
         * メッセージIDを設定
         *
         * @param messageName メッセージID
         * @return this
         */
        public ReadMessageByUserIdRequest WithMessageName(string messageName) {
            this.messageName = messageName;
            return this;
        }


        /** スタンプシートの変数に適用する設定値 */
        public List<Config> config { set; get; }

        /**
         * スタンプシートの変数に適用する設定値を設定
         *
         * @param config スタンプシートの変数に適用する設定値
         * @return this
         */
        public ReadMessageByUserIdRequest WithConfig(List<Config> config) {
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
        public ReadMessageByUserIdRequest WithDuplicationAvoider(string duplicationAvoider) {
            this.duplicationAvoider = duplicationAvoider;
            return this;
        }


	}
}