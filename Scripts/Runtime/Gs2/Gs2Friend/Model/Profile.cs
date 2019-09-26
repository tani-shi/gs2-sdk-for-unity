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

namespace Gs2.Gs2Friend.Model
{
	public class Profile
	{

        /** プロフィール */
        public string profileId { set; get; }

        /**
         * プロフィールを設定
         *
         * @param profileId プロフィール
         * @return this
         */
        public Profile WithProfileId(string profileId) {
            this.profileId = profileId;
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
        public Profile WithUserId(string userId) {
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
        public Profile WithPublicProfile(string publicProfile) {
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
        public Profile WithFollowerProfile(string followerProfile) {
            this.followerProfile = followerProfile;
            return this;
        }

        /** フレンド向けに公開されるプロフィール */
        public string friendProfile { set; get; }

        /**
         * フレンド向けに公開されるプロフィールを設定
         *
         * @param friendProfile フレンド向けに公開されるプロフィール
         * @return this
         */
        public Profile WithFriendProfile(string friendProfile) {
            this.friendProfile = friendProfile;
            return this;
        }

        /** 作成日時 */
        public long? createdAt { set; get; }

        /**
         * 作成日時を設定
         *
         * @param createdAt 作成日時
         * @return this
         */
        public Profile WithCreatedAt(long? createdAt) {
            this.createdAt = createdAt;
            return this;
        }

        /** 最終更新日時 */
        public long? updatedAt { set; get; }

        /**
         * 最終更新日時を設定
         *
         * @param updatedAt 最終更新日時
         * @return this
         */
        public Profile WithUpdatedAt(long? updatedAt) {
            this.updatedAt = updatedAt;
            return this;
        }

        public void WriteJson(JsonWriter writer)
        {
            writer.WriteObjectStart();
            if(this.profileId != null)
            {
                writer.WritePropertyName("profileId");
                writer.Write(this.profileId);
            }
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
            if(this.friendProfile != null)
            {
                writer.WritePropertyName("friendProfile");
                writer.Write(this.friendProfile);
            }
            if(this.createdAt.HasValue)
            {
                writer.WritePropertyName("createdAt");
                writer.Write(this.createdAt.Value);
            }
            if(this.updatedAt.HasValue)
            {
                writer.WritePropertyName("updatedAt");
                writer.Write(this.updatedAt.Value);
            }
            writer.WriteObjectEnd();
        }
	}
}