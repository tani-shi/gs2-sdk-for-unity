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
using LitJson;

namespace Gs2.Gs2Showcase.Model
{
	public class ConsumeAction
	{

        /** スタンプタスクで実行するアクションの種類 */
        public string action { set; get; }

        /**
         * スタンプタスクで実行するアクションの種類を設定
         *
         * @param action スタンプタスクで実行するアクションの種類
         * @return this
         */
        public ConsumeAction WithAction(string action) {
            this.action = action;
            return this;
        }

        /** 消費リクエストのJSON */
        public string request { set; get; }

        /**
         * 消費リクエストのJSONを設定
         *
         * @param request 消費リクエストのJSON
         * @return this
         */
        public ConsumeAction WithRequest(string request) {
            this.request = request;
            return this;
        }

        public void WriteJson(JsonWriter writer)
        {
            writer.WriteObjectStart();
            if(this.action != null)
            {
                writer.WritePropertyName("action");
                writer.Write(this.action);
            }
            if(this.request != null)
            {
                writer.WritePropertyName("request");
                writer.Write(this.request);
            }
            writer.WriteObjectEnd();
        }
	}
}