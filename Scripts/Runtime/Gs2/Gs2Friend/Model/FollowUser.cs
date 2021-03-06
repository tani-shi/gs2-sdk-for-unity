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
using LitJson;
using UnityEngine.Scripting;

namespace Gs2.Gs2Friend.Model
{
	[Preserve]
	public class FollowUser
	{

        /** ユーザーID */
        public string userId { set; get; }

        /**
         * ユーザーIDを設定
         *
         * @param userId ユーザーID
         * @return this
         */
        public FollowUser WithUserId(string userId) {
            this.userId = userId;
            return this;
        }

        /** 公開されるプロフィール */
        public string publicProfile { set; get; }

        /**
         * 公開されるプロフィールを設定
         *
         * @param publicProfile 公開されるプロフィール
         * @return this
         */
        public FollowUser WithPublicProfile(string publicProfile) {
            this.publicProfile = publicProfile;
            return this;
        }

        /** フォロワー向けに公開されるプロフィール */
        public string followerProfile { set; get; }

        /**
         * フォロワー向けに公開されるプロフィールを設定
         *
         * @param followerProfile フォロワー向けに公開されるプロフィール
         * @return this
         */
        public FollowUser WithFollowerProfile(string followerProfile) {
            this.followerProfile = followerProfile;
            return this;
        }

        public void WriteJson(JsonWriter writer)
        {
            writer.WriteObjectStart();
            if(this.userId != null)
            {
                writer.WritePropertyName("userId");
                writer.Write(this.userId);
            }
            if(this.publicProfile != null)
            {
                writer.WritePropertyName("publicProfile");
                writer.Write(this.publicProfile);
            }
            if(this.followerProfile != null)
            {
                writer.WritePropertyName("followerProfile");
                writer.Write(this.followerProfile);
            }
            writer.WriteObjectEnd();
        }

    	[Preserve]
        public static FollowUser FromDict(JsonData data)
        {
            return new FollowUser()
                .WithUserId(data.Keys.Contains("userId") && data["userId"] != null ? data["userId"].ToString() : null)
                .WithPublicProfile(data.Keys.Contains("publicProfile") && data["publicProfile"] != null ? data["publicProfile"].ToString() : null)
                .WithFollowerProfile(data.Keys.Contains("followerProfile") && data["followerProfile"] != null ? data["followerProfile"].ToString() : null);
        }
	}
}