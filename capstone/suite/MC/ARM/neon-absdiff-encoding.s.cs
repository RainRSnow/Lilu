# CS_ARCH_ARM, CS_MODE_ARM, None
0xa1,0x07,0x40,0xf2 = vabd.s8 d16, d16, d17
0xa1,0x07,0x50,0xf2 = vabd.s16 d16, d16, d17
0xa1,0x07,0x60,0xf2 = vabd.s32 d16, d16, d17
0xa1,0x07,0x40,0xf3 = vabd.u8 d16, d16, d17
0xa1,0x07,0x50,0xf3 = vabd.u16 d16, d16, d17
0xa1,0x07,0x60,0xf3 = vabd.u32 d16, d16, d17
0xa1,0x0d,0x60,0xf3 = vabd.f32 d16, d16, d17
0xe2,0x07,0x40,0xf2 = vabd.s8 q8, q8, q9
0xe2,0x07,0x50,0xf2 = vabd.s16 q8, q8, q9
0xe2,0x07,0x60,0xf2 = vabd.s32 q8, q8, q9
0xe2,0x07,0x40,0xf3 = vabd.u8 q8, q8, q9
0xe2,0x07,0x50,0xf3 = vabd.u16 q8, q8, q9
0xe2,0x07,0x60,0xf3 = vabd.u32 q8, q8, q9
0xe2,0x0d,0x60,0xf3 = vabd.f32 q8, q8, q9
0xa1,0x07,0xc0,0xf2 = vabdl.s8 q8, d16, d17
0xa1,0x07,0xd0,0xf2 = vabdl.s16 q8, d16, d17
0xa1,0x07,0xe0,0xf2 = vabdl.s32 q8, d16, d17
0xa1,0x07,0xc0,0xf3 = vabdl.u8 q8, d16, d17
0xa1,0x07,0xd0,0xf3 = vabdl.u16 q8, d16, d17
0xa1,0x07,0xe0,0xf3 = vabdl.u32 q8, d16, d17
0xb1,0x07,0x42,0xf2 = vaba.s8 d16, d18, d17
0xb1,0x07,0x52,0xf2 = vaba.s16 d16, d18, d17
0xb1,0x07,0x62,0xf2 = vaba.s32 d16, d18, d17
0xb1,0x07,0x42,0xf3 = vaba.u8 d16, d18, d17
0xb1,0x07,0x52,0xf3 = vaba.u16 d16, d18, d17
0xb1,0x07,0x62,0xf3 = vaba.u32 d16, d18, d17
0xf4,0x27,0x40,0xf2 = vaba.s8 q9, q8, q10
0xf4,0x27,0x50,0xf2 = vaba.s16 q9, q8, q10
0xf4,0x27,0x60,0xf2 = vaba.s32 q9, q8, q10
0xf4,0x27,0x40,0xf3 = vaba.u8 q9, q8, q10
0xf4,0x27,0x50,0xf3 = vaba.u16 q9, q8, q10
0xf4,0x27,0x60,0xf3 = vaba.u32 q9, q8, q10
0xa2,0x05,0xc3,0xf2 = vabal.s8 q8, d19, d18
0xa2,0x05,0xd3,0xf2 = vabal.s16 q8, d19, d18
0xa2,0x05,0xe3,0xf2 = vabal.s32 q8, d19, d18
0xa2,0x05,0xc3,0xf3 = vabal.u8 q8, d19, d18
0xa2,0x05,0xd3,0xf3 = vabal.u16 q8, d19, d18
0xa2,0x05,0xe3,0xf3 = vabal.u32 q8, d19, d18
