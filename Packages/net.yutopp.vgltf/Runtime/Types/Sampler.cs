//
// Copyright (c) 2019- yutopp (yutopp@gmail.com)
//
// Distributed under the Boost Software License, Version 1.0. (See accompanying
// file LICENSE_1_0.txt or copy at  https://www.boost.org/LICENSE_1_0.txt)
//

using System;
using VJson;
using VJson.Schema;

// Reference: https://github.com/KhronosGroup/glTF/blob/master/specification/2.0/schema/*
namespace VGltf.Types
{
    [JsonSchema(Id = "sampler.schema.json")]
    public sealed class Sampler : GltfChildOfRootProperty
    {
        [JsonField(Name = "magFilter"), JsonFieldIgnorable]
        public MagFilterEnum? MagFilter;

        [JsonField(Name = "minFilter"), JsonFieldIgnorable]
        public MinFilterEnum? MinFilter;

        [JsonField(Name = "wrapS"), JsonFieldIgnorable(WhenValueIs = WrapEnum.Repeat)]
        public WrapEnum WrapS = WrapEnum.Repeat;

        [JsonField(Name = "wrapT"), JsonFieldIgnorable(WhenValueIs = WrapEnum.Repeat)]
        public WrapEnum WrapT = WrapEnum.Repeat;

        //

        public enum MagFilterEnum
        {
            NEAREST = 9728,
            LINEAR = 9729,
        }

        public enum MinFilterEnum
        {
            NEAREST = 9728,
            LINEAR = 9729,
            NEAREST_MIPMAP_NEAREST = 9984,
            LINEAR_MIPMAP_NEAREST = 9985,
            NEAREST_MIPMAP_LINEAR = 9986,
            LINEAR_MIPMAP_LINEAR = 9987,
        }

        public enum WrapEnum
        {
            ClampToEdge = 33071,
            MirroredRepeat = 33648,
            Repeat = 10497,
        }
    }
}
