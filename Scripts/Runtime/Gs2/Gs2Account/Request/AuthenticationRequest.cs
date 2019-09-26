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
using Gs2.Gs2Account.Model;

namespace Gs2.Gs2Account.Request
{
	public class AuthenticationRequest : Gs2Request<AuthenticationRequest>
	{

        /** ネームスペース名 */
        public string namespaceName { set; get; }

        /**
         * ネームスペース名を設定
         *
         * @param namespaceName ネームスペース名
         * @return this
         */
        public AuthenticationRequest WithNamespaceName(string namespaceName) {
            this.namespaceName = namespaceName;
            return this;
        }


        /** アカウントID */
        public string userId { set; get; }

        /**
         * アカウントIDを設定
         *
         * @param userId アカウントID
         * @return this
         */
        public AuthenticationRequest WithUserId(string userId) {
            this.userId = userId;
            return this;
        }


        /** 認証トークンの暗号化に使用する暗号鍵 のGRN */
        public string keyId { set; get; }

        /**
         * 認証トークンの暗号化に使用する暗号鍵 のGRNを設定
         *
         * @param keyId 認証トークンの暗号化に使用する暗号鍵 のGRN
         * @return this
         */
        public AuthenticationRequest WithKeyId(string keyId) {
            this.keyId = keyId;
            return this;
        }


        /** パスワード */
        public string password { set; get; }

        /**
         * パスワードを設定
         *
         * @param password パスワード
         * @return this
         */
        public AuthenticationRequest WithPassword(string password) {
            this.password = password;
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
        public AuthenticationRequest WithDuplicationAvoider(string duplicationAvoider) {
            this.duplicationAvoider = duplicationAvoider;
            return this;
        }


	}
}