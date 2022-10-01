﻿using FlatSharp.Attributes;

namespace pkNX.Structures.FlatBuffers;

#pragma warning disable RCS1154 // Sort enum members.

[FlatBufferEnum(typeof(ulong))]
public enum NPCModelType8a : ulong
{
    tr0002_00_doctor_b_m = 0x015db2a7cffba36d, //tr0002_00_doctor_b_m
    tr0003_00_ouji_m = 0xfa390faa8a4c1195, //tr0003_00_ouji_m
    tr0004_00_hime_f = 0xff11e824ea817ea9, //tr0004_00_hime_f
    tr0005_00_boss1_m = 0x37a1055c1b515da2, //tr0005_00_boss1_m
    tr0006_00_boss2_m = 0xabdd9bc2cbc5c8e0, //tr0006_00_boss2_m
    tr0007_00_si1_m = 0x2e28bdf747ec942b, //tr0007_00_si1_m
    tr0008_00_si2_m = 0x44f6b0dd54e4a9d9, //tr0008_00_si2_m
    tr0009_00_ninja1_m = 0xe18dacd6c3fd8cdd, //tr0009_00_ninja1_m
    tr0009_00_ninja1_m_item = 0x5f81bc8b17a32525, //tr0009_00_ninja1_m_item
    tr0010_00_ninja2_m = 0x161c054da3ba2366, //tr0010_00_ninja2_m
    tr0011_00_miko_f = 0xce4088951c0ec456, //tr0011_00_miko_f
    tr0012_00_captain1_f = 0xb311d8f4aa587894, //tr0012_00_captain1_f
    tr0013_00_captain2_m = 0x88e173dce0a38833, //tr0013_00_captain2_m
    tr0014_00_captain3_f = 0x3f767c4cb5b03854, //tr0014_00_captain3_f
    tr0015_00_captain4_f = 0x76b41752fd20f1f2, //tr0015_00_captain4_f
    tr0016_00_captain5_m = 0x982521202cb9122d, //tr0016_00_captain5_m
    tr0017_00_captain6_f = 0xd10fbb6753708e16, //tr0017_00_captain6_f
    tr0018_00_captain7_m = 0x12a13d7cadba0d3d, //tr0018_00_captain7_m
    tr0019_00_captain8_m = 0x6dd37e1e32b0acd7, //tr0019_00_captain8_m
    tr0020_00_captain9_m = 0xf38b82cb739db028, //tr0020_00_captain9_m
    tr0021_00_captain10_f = 0x9529c8e4c72631d4, //tr0021_00_captain10_f
    tr0022_00_guard_leader_f = 0xd877e54f29fa9593, //tr0022_00_guard_leader_f
    tr0023_00_guard_lower_m = 0xdba19996b0fb2659, //tr0023_00_guard_lower_m
    tr0023_00_guard_lower_m_item = 0x0f3c78f2e54ec949, //tr0023_00_guard_lower_m_item
    tr0024_00_guard_lower_f = 0x0fcf1af5301681db, //tr0024_00_guard_lower_f
    tr0024_00_guard_lower_f_item = 0xd85aa84c35dfb283, //tr0024_00_guard_lower_f_item
    tr0025_00_trade_boss_m = 0x7a07ae18e03af6e6, //tr0025_00_trade_boss_m
    tr0027_00_me_leader_f = 0x5c3fa828bc5ed4e5, //tr0027_00_me_leader_f
    tr0031_00_trade_m = 0x1ec8edf64a8343a1, //tr0031_00_trade_m
    tr0032_00_trade_f = 0xc8e1debc5d26dbab, //tr0032_00_trade_f
    tr0033_00_bandit_first_f = 0x35c5c774238280c5, //tr0033_00_bandit_first_f
    tr0034_00_bandit_second_f = 0xb822d32541dbb044, //tr0034_00_bandit_second_f
    tr0035_00_bandit_third_f = 0x6d0bd5332e9c75a0, //tr0035_00_bandit_third_f
    tr0036_00_senpai_m = 0x2d992cf818c93910, //tr0036_00_senpai_m
    tr0037_00_senpai_f = 0xfca68432c5c9b79e, //tr0037_00_senpai_f
    tr0038_00_bu_leader_f = 0x5dc0bb9fd426f508, //tr0038_00_bu_leader_f
    cc0001_00_re_leader_f = 0x1408408a4bb9e9c8, //cc0001_00_re_leader_f
    cc0002_00_clothowner_f = 0x16b93073905e4901, //cc0002_00_clothowner_f
    cc0004_00_toolowner_m = 0x5ef6f1d24e71c946, //cc0004_00_toolowner_m
    cc0005_00_ag_leader_m = 0xa5efbb64d7ba6e6e, //cc0005_00_ag_leader_m
    cc0006_00_ag_middle_m_a = 0x10844c4a1781e15d, //cc0006_00_ag_middle_m_a
    cc0006_00_ag_middle_m_a_cfl_m = 0x5ec3ec379e4de489, //cc0006_00_ag_middle_m_a_cfl_m
    cc0006_00_ag_middle_m_a_wld_m = 0x34bae2cb8c39e8f3, //cc0006_00_ag_middle_m_a_wld_m
    cc0006_00_ag_middle_m_a_lsp = 0x0cfa94c32e92a785, //cc0006_00_ag_middle_m_a_lsp
    cc0006_00_ag_middle_m_a_item = 0xa4e8e6d1c24cd2a5, //cc0006_00_ag_middle_m_a_item
    cc0007_00_ag_young_m = 0x506715d3557f8e07, //cc0007_00_ag_young_m
    cc0007_00_ag_young_m_cfl_m = 0xec20a8cf1a3d2a73, //cc0007_00_ag_young_m_cfl_m
    cc0007_00_ag_young_m_wld_m = 0x2b22978e843ddf69, //cc0007_00_ag_young_m_wld_m
    cc0007_00_ag_young_m_lsp = 0xe7566578e481c387, //cc0007_00_ag_young_m_lsp
    cc0007_00_ag_young_m_item = 0xd6599953e6cfe317, //cc0007_00_ag_young_m_item
    cc0009_00_bu_old_m = 0xeb9519d27e542415, //cc0009_00_bu_old_m
    cc0009_00_bu_old_m_item = 0xeda4785873a4ee1d, //cc0009_00_bu_old_m_item
    cc0010_00_bu_young_f = 0x06d7f6ee3021f773, //cc0010_00_bu_young_f
    cc0010_00_bu_young_f_cfl_f = 0xc66297bada21fec2, //cc0010_00_bu_young_f_cfl_f
    cc0010_00_bu_young_f_wld_f = 0x72680bc00f2fa734, //cc0010_00_bu_young_f_wld_f
    cc0010_00_bu_young_f_lsp = 0xb1429fb29e42d7f3, //cc0010_00_bu_young_f_lsp
    cc0010_00_bu_young_f_item = 0x5b6a85ac79398f3b, //cc0010_00_bu_young_f_item
    cc0014_00_me_old_f = 0xde3b67329949d799, //cc0014_00_me_old_f
    cc0014_00_me_old_f_lsp = 0x1bee7b2f9fe0aec1, //cc0014_00_me_old_f_lsp
    cc0014_00_me_old_f_lsp_bft = 0xc086b27de81ab83a, //cc0014_00_me_old_f_lsp_bft
    cc0015_00_pr_old_m = 0xfca7fde968ca3ccb, //cc0015_00_pr_old_m
    cc0015_00_pr_old_m_lsp = 0x0872aeff10041a2b, //cc0015_00_pr_old_m_lsp
    cc0015_00_pr_old_m_lsp_bft = 0x6105119969aeb340, //cc0015_00_pr_old_m_lsp_bft
    cc0016_00_pr_young_f = 0xc29b0d7b259978ee, //cc0016_00_pr_young_f
    cc0016_00_pr_young_f_cfl_f = 0x962f868bf5c2751b, //cc0016_00_pr_young_f_cfl_f
    cc0016_00_pr_young_f_wld_f = 0x37e90b5e50520a8d, //cc0016_00_pr_young_f_wld_f
    cc0016_00_pr_young_f_lsp = 0xa8b8f536108d0fee, //cc0016_00_pr_young_f_lsp
    cc0018_00_pr_leader_m = 0x411dfbaeb8a45ba2, //cc0018_00_pr_leader_m
    cc0021_00_vi_young_m_a = 0xc2d1029b47f9e78a, //cc0021_00_vi_young_m_a
    cc0021_00_vi_young_m_a_cfl_m = 0x8acfbc1a85c4b31a, //cc0021_00_vi_young_m_a_cfl_m
    cc0021_00_vi_young_m_a_wld_m = 0xf151b41f93620d18, //cc0021_00_vi_young_m_a_wld_m
    cc0021_00_vi_young_m_a_lsp = 0xbcc86a13c6f0b36a, //cc0021_00_vi_young_m_a_lsp
    cc0021_00_vi_young_m_a_lsp_bft = 0xc19a96ff27645a55, //cc0021_00_vi_young_m_a_lsp_bft
    cc0022_00_vi_young_m_b = 0xd915b8f4b0ebb8de, //cc0022_00_vi_young_m_b
    cc0022_00_vi_young_m_b_cfl_m = 0xbc197e1c1a0325a6, //cc0022_00_vi_young_m_b_cfl_m
    cc0022_00_vi_young_m_b_wld_m = 0xf15f1dcb20f635ec, //cc0022_00_vi_young_m_b_wld_m
    cc0022_00_vi_young_m_b_lsp = 0x179bef56b0b22a7e, //cc0022_00_vi_young_m_b_lsp
    cc0023_00_vi_young_m_b = 0x986ed5a488336fa1, //cc0023_00_vi_young_m_b
    cc0023_00_vi_young_m_b_cfl_m = 0x8b48a0a46e8b00e5, //cc0023_00_vi_young_m_b_cfl_m
    cc0023_00_vi_young_m_b_wld_m = 0x88bf38a4217dcad7, //cc0023_00_vi_young_m_b_wld_m
    cc0023_00_vi_young_m_b_lsp = 0x4bc5566e3397b969, //cc0023_00_vi_young_m_b_lsp
    cc0023_00_vi_young_m_b_item = 0x2253f02511096c11, //cc0023_00_vi_young_m_b_item
    cc0023_00_vi_young_m_b_item2 = 0x5e0d31fbf302bf79, //cc0023_00_vi_young_m_b_item2
    cc0024_00_vi_young_m_a = 0x1737a10883eea3f1, //cc0024_00_vi_young_m_a
    cc0024_00_vi_young_m_a_cfl_m = 0x19cc9672fe660b35, //cc0024_00_vi_young_m_a_cfl_m
    cc0024_00_vi_young_m_a_wld_m = 0x2cad15d43ab425c7, //cc0024_00_vi_young_m_a_wld_m
    cc0024_00_vi_young_m_a_lsp = 0x843d758ad97e2e59, //cc0024_00_vi_young_m_a_lsp
    cc0024_00_vi_young_m_a_item = 0xa6cdfdd7dffe0981, //cc0024_00_vi_young_m_a_item
    cc0025_00_vi_young_f_a = 0x8e16de352843c367, //cc0025_00_vi_young_f_a
    cc0025_00_vi_young_f_a_cfl_f = 0x721c8f52bdd9841e, //cc0025_00_vi_young_f_a_cfl_f
    cc0025_00_vi_young_f_a_wld_f = 0x043c7a0d3cf6ab48, //cc0025_00_vi_young_f_a_wld_f
    cc0025_00_vi_young_f_a_kmn_f = 0x5bf799b5f279dd57, //cc0025_00_vi_young_f_a_kmn_f
    cc0025_00_vi_young_f_a_lsp = 0x4cb2ef0a57027da7, //cc0025_00_vi_young_f_a_lsp
    cc0026_00_vi_young_f_b = 0x0e93b2023d2e0483, //cc0026_00_vi_young_f_b
    cc0026_00_vi_young_f_b_cfl_f = 0x103d1c9991da9152, //cc0026_00_vi_young_f_b_cfl_f
    cc0026_00_vi_young_f_b_wld_f = 0xfd5ba938558ad824, //cc0026_00_vi_young_f_b_wld_f
    cc0026_00_vi_young_f_b_kmn_f = 0x5a7a2dd4048d484b, //cc0026_00_vi_young_f_b_kmn_f
    cc0026_00_vi_young_f_b_lsp = 0x99159d3ad36208a3, //cc0026_00_vi_young_f_b_lsp
    cc0026_00_vi_young_f_b_lsp_bft = 0xcf0dd9bee47edc68, //cc0026_00_vi_young_f_b_lsp_bft
    cc0026_00_vi_young_f_b_item = 0x65b3841ebcdd51eb, //cc0026_00_vi_young_f_b_item
    cc0027_00_vi_young_f_a = 0x7883ecd5fc733859, //cc0027_00_vi_young_f_a
    cc0027_00_vi_young_f_a_cfl_f = 0xb159a0a8a1617d0c, //cc0027_00_vi_young_f_a_cfl_f
    cc0027_00_vi_young_f_a_wld_f = 0x0e08de3792e6f43a, //cc0027_00_vi_young_f_a_wld_f
    cc0027_00_vi_young_f_a_kmn_f = 0x75a8d7c29c71de05, //cc0027_00_vi_young_f_a_kmn_f
    cc0027_00_vi_young_f_a_lsp = 0x4a3099760fb0f681, //cc0027_00_vi_young_f_a_lsp
    cc0027_00_vi_young_f_a_item = 0x1f45be845a31bf49, //cc0027_00_vi_young_f_a_item
    cc0027_00_vi_young_f_a_lsp_bft = 0x8457f2e71cd2b4fa, //cc0027_00_vi_young_f_a_lsp_bft
    cc0028_00_vi_young_f_b = 0x04db31ca07760e51, //cc0028_00_vi_young_f_b
    cc0028_00_vi_young_f_b_cfl_f = 0x05e8ac43eb76c094, //cc0028_00_vi_young_f_b_cfl_f
    cc0028_00_vi_young_f_b_wld_f = 0x1a7d1fa529380e42, //cc0028_00_vi_young_f_b_wld_f
    cc0028_00_vi_young_f_b_kmn_f = 0x3e071352da13b30d, //cc0028_00_vi_young_f_b_kmn_f
    cc0028_00_vi_young_f_b_lsp = 0xa8119b81d95a35f9, //cc0028_00_vi_young_f_b_lsp
    cc0028_00_vi_young_f_b_item = 0xbe3ce087bdc30fa1, //cc0028_00_vi_young_f_b_item
    cc0029_00_vi_middle_m_a = 0x72ab0bb01bc2bb07, //cc0029_00_vi_middle_m_a
    cc0029_00_vi_middle_m_a_cfl_m = 0x4a80c83591002f73, //cc0029_00_vi_middle_m_a_cfl_m
    cc0029_00_vi_middle_m_a_wld_m = 0x8982b6f4fb00e469, //cc0029_00_vi_middle_m_a_wld_m
    cc0029_00_vi_middle_m_a_lsp = 0x9007ce24d69a4087, //cc0029_00_vi_middle_m_a_lsp
    cc0029_00_vi_middle_m_a_lsp_bft = 0x82ecdcf0b3883314, //cc0029_00_vi_middle_m_a_lsp_bft
    cc0030_00_vi_middle_m_b = 0xec11addf2d40fc8c, //cc0030_00_vi_middle_m_b
    cc0030_00_vi_middle_m_b_cfl_m = 0xe2ed8c2a8f5dc9ac, //cc0030_00_vi_middle_m_b_cfl_m
    cc0030_00_vi_middle_m_b_wld_m = 0xe4cc7b90db1ac94e, //cc0030_00_vi_middle_m_b_wld_m
    cc0030_00_vi_middle_m_b_lsp = 0xcefd90a15967be9c, //cc0030_00_vi_middle_m_b_lsp
    cc0031_00_vi_middle_m_a = 0x1bc704ef873730f0, //cc0031_00_vi_middle_m_a
    cc0031_00_vi_middle_m_a_cfl_m = 0xff079afd97d9dde8, //cc0031_00_vi_middle_m_a_cfl_m
    cc0031_00_vi_middle_m_a_wld_m = 0xfdb06b36f095f752, //cc0031_00_vi_middle_m_a_wld_m
    cc0031_00_vi_middle_m_a_lsp = 0x6d50ef372427fda0, //cc0031_00_vi_middle_m_a_lsp
    cc0031_00_vi_middle_m_a_item = 0xa85604cacebf6ade, //cc0031_00_vi_middle_m_a_item
    cc0032_00_vi_middle_f_a = 0x8174f1986cac6656, //cc0032_00_vi_middle_f_a
    cc0032_00_vi_middle_f_a_cfl_f = 0x8d11cfc290fcb3f3, //cc0032_00_vi_middle_f_a_cfl_f
    cc0032_00_vi_middle_f_a_wld_f = 0xba62c3050ff8d8e5, //cc0032_00_vi_middle_f_a_wld_f
    cc0032_00_vi_middle_f_a_kmn_f = 0x3b93e4acce4a2b1e, //cc0032_00_vi_middle_f_a_kmn_f
    cc0032_00_vi_middle_f_a_lsp = 0xab6c17639da62c76, //cc0032_00_vi_middle_f_a_lsp
    cc0032_00_vi_middle_f_a_lsp_bft = 0xf70c4cb7d2550159, //cc0032_00_vi_middle_f_a_lsp_bft
    cc0032_00_vi_middle_f_a_item = 0xa2893a1b18d8ff2c, //cc0032_00_vi_middle_f_a_item
    cc0033_00_vi_middle_f_b = 0xf5aa357a2bc1005e, //cc0033_00_vi_middle_f_b
    cc0033_00_vi_middle_f_b_cfl_f = 0xf06e88cf384d1d0b, //cc0033_00_vi_middle_f_b_cfl_f
    cc0033_00_vi_middle_f_b_wld_f = 0x25b42c7e3f40341d, //cc0033_00_vi_middle_f_b_wld_f
    cc0033_00_vi_middle_f_b_lsp = 0x67c2cd52b181a9fe, //cc0033_00_vi_middle_f_b_lsp
    cc0033_00_vi_middle_f_b_kmn_f = 0x51deb61bf33af976, //cc0033_00_vi_middle_f_b_kmn_f
    cc0033_00_vi_middle_f_b_item = 0x8856f759d955bf94, //cc0033_00_vi_middle_f_b_item
    cc0034_00_vi_old_m_a = 0x858bc385431f55f9, //cc0034_00_vi_old_m_a
    cc0034_00_vi_old_m_a_lsp = 0x14114b3a99c66ce1, //cc0034_00_vi_old_m_a_lsp
    cc0034_00_vi_old_m_a_item = 0x40f06f7aff8d7a29, //cc0034_00_vi_old_m_a_item
    cc0035_00_vi_old_m_b = 0x23d31478c92260f7, //cc0035_00_vi_old_m_b
    cc0035_00_vi_old_m_b_lsp = 0xd89777f3b2612d97, //cc0035_00_vi_old_m_b_lsp
    cc0035_00_vi_old_m_b_lsp_bft = 0x65b3cfc67ee5f4a4, //cc0035_00_vi_old_m_b_lsp_bft
    cc0035_00_vi_old_m_b_item = 0xab290fffbcb11727, //cc0035_00_vi_old_m_b_item
    cc0036_00_vi_old_f_a = 0x9fd14fc4675e04c2, //cc0036_00_vi_old_f_a
    cc0036_00_vi_old_f_a_lsp = 0x336b4912c1afac82, //cc0036_00_vi_old_f_a_lsp
    cc0037_00_vi_old_f_b = 0x9d657ba003e7c2b8, //cc0037_00_vi_old_f_b
    cc0037_00_vi_old_f_b_lsp = 0x0c96682f46e9c228, //cc0037_00_vi_old_f_b_lsp
    cc0038_00_vi_children_m = 0xe11324232b3d88eb, //cc0038_00_vi_children_m
    cc0038_00_vi_children_m_lsp = 0x57b61ef59c929a0b, //cc0038_00_vi_children_m_lsp
    cc0038_00_vi_children_m_lsp_bft = 0xc59982ec2af4bf60, //cc0038_00_vi_children_m_lsp_bft
    cc0039_00_vi_children_f_b = 0x74895cd2d12b60b6, //cc0039_00_vi_children_f_b
    cc0039_00_vi_children_f_b_lsp = 0x91a302d3bf75e396, //cc0039_00_vi_children_f_b_lsp
    cc0039_00_vi_children_f_b_lsp_bft = 0x929084c17fcb3bb9, //cc0039_00_vi_children_f_b_lsp_bft
    cc0040_00_vi_infant_m = 0x61fb4b52eb02fffd, //cc0040_00_vi_infant_m
    cc0040_00_vi_infant_m_lsp = 0x28a0a31c1f09aee5, //cc0040_00_vi_infant_m_lsp
    cc0040_00_vi_infant_m_lsp_bft = 0x02d62f3e278e32b6, //cc0040_00_vi_infant_m_lsp_bft
    cc0041_00_vi_infant_f = 0x854645cb6e81413d, //cc0041_00_vi_infant_f
    cc0041_00_vi_infant_f_lsp = 0x4938b32be407b025, //cc0041_00_vi_infant_f_lsp
    cc0041_00_vi_infant_f_lsp_bft = 0x34600801ac046cf6, //cc0041_00_vi_infant_f_lsp_bft
    cc0042_00_na_young_m_d = 0xd8b098e45757042a, //cc0042_00_na_young_m_d
    cc0042_00_na_young_m_d_cfl_m = 0x6fb5c25f238ccdba, //cc0042_00_na_young_m_d_cfl_m
    cc0042_00_na_young_m_d_wld_m = 0xd7ebba64329d6f38, //cc0042_00_na_young_m_d_wld_m
    cc0042_00_na_young_m_d_lsp = 0x81498ba3c0a76fca, //cc0042_00_na_young_m_d_lsp
    cc0043_00_na_young_f_d = 0x29a6181cf4fd8418, //cc0043_00_na_young_f_d
    cc0043_00_na_young_f_d_cfl_f = 0xe3535d5450f0ee01, //cc0043_00_na_young_f_d_cfl_f
    cc0043_00_na_young_f_d_wld_f = 0x7e2e917c3f7165af, //cc0043_00_na_young_f_d_wld_f
    cc0043_00_na_young_f_d_lsp = 0xc57e0f75df4910c8, //cc0043_00_na_young_f_d_lsp
    cc0044_00_na_young_m_p = 0x3f9bce000dc87e98, //cc0044_00_na_young_m_p
    cc0044_00_na_young_m_p_cfl_m = 0x32f3a5102661a1d0, //cc0044_00_na_young_m_p_cfl_m
    cc0044_00_na_young_m_p_wld_m = 0xcdceed3814e23b7a, //cc0044_00_na_young_m_p_wld_m
    cc0044_00_na_young_m_p_lsp = 0xe13b0178d6b6f348, //cc0044_00_na_young_m_p_lsp
    cc0045_00_na_young_f_p = 0x8133f4a30f46cc82, //cc0045_00_na_young_f_p
    cc0045_00_na_young_f_p_cfl_f = 0x868655d5123f7937, //cc0045_00_na_young_f_p_cfl_f
    cc0045_00_na_young_f_p_wld_f = 0x228e025d5dba7e81, //cc0045_00_na_young_f_p_wld_f
    cc0045_00_na_young_f_p_lsp = 0x833a66f837650042, //cc0045_00_na_young_f_p_lsp
    cc0046_00_na_middle_m_d = 0xc55a3ad587a4e759, //cc0046_00_na_middle_m_d
    cc0046_00_na_middle_m_d_cfl_m = 0xb0e3e5ffcbcb86bd, //cc0046_00_na_middle_m_d_cfl_m
    cc0046_00_na_middle_m_d_wld_m = 0x0d930f8ebd50dbef, //cc0046_00_na_middle_m_d_wld_m
    cc0046_00_na_middle_m_d_lsp = 0xd0a66b7f9e591581, //cc0046_00_na_middle_m_d_lsp
    cc0047_00_na_middle_f_d = 0xee2c767cf4246455, //cc0047_00_na_middle_f_d
    cc0047_00_na_middle_f_d_cfl_f = 0xda7c1f25bb0863d0, //cc0047_00_na_middle_f_d_cfl_f
    cc0047_00_na_middle_f_d_wld_f = 0x3efc83e1dc0ed5a6, //cc0047_00_na_middle_f_d_wld_f
    cc0047_00_na_middle_f_d_lsp = 0x65c06383032b331d, //cc0047_00_na_middle_f_d_lsp
    cc0048_00_na_middle_m_p = 0xa5c962a0523fcbff, //cc0048_00_na_middle_m_p
    cc0048_00_na_middle_m_p_cfl_m = 0x62ea740375a6a00b, //cc0048_00_na_middle_m_p_cfl_m
    cc0048_00_na_middle_m_p_wld_m = 0xfe6a134754a03501, //cc0048_00_na_middle_m_p_wld_m
    cc0048_00_na_middle_m_p_lsp = 0xe2bd31d0bace7a1f, //cc0048_00_na_middle_m_p_lsp
    cc0049_00_na_middle_f_p = 0xea53852ff31b5317, //cc0049_00_na_middle_f_p
    cc0049_00_na_middle_f_p_cfl_f = 0xbf0815edd64692ce, //cc0049_00_na_middle_f_p_cfl_f
    cc0049_00_na_middle_f_p_wld_f = 0xe5aadb59e576f1d8, //cc0049_00_na_middle_f_p_wld_f
    cc0049_00_na_middle_f_p_lsp = 0x8666b9928068fbf7, //cc0049_00_na_middle_f_p_lsp
    cc0050_00_na_old_m_d_a = 0xa0da88353e0fa1b4, //cc0050_00_na_old_m_d_a
    cc0050_00_na_old_m_d_a_lsp = 0x86cdaeb4b7cc6e24, //cc0050_00_na_old_m_d_a_lsp
    cc0052_00_na_old_f_d = 0xb97cfb7f26aa203f, //cc0052_00_na_old_f_d
    cc0052_00_na_old_f_d_lsp = 0xdf6bc483a2758b5f, //cc0052_00_na_old_f_d_lsp
    cc0053_00_na_old_m_p_a = 0xee1afc2839a98f41, //cc0053_00_na_old_m_p_a
    cc0053_00_na_old_m_p_a_lsp = 0x21a2423df7d03549, //cc0053_00_na_old_m_p_a_lsp
    cc0054_00_na_old_f_p_a = 0xcce10df9378410cd, //cc0054_00_na_old_f_p_a
    cc0054_00_na_old_f_p_a_lsp = 0xa4cbdd67d2a15155, //cc0054_00_na_old_f_p_a_lsp
    cc0056_00_na_children_f_d = 0x19d3611a614bd879, //cc0056_00_na_children_f_d
    cc0056_00_na_children_f_d_lsp = 0x2a6f55e765525761, //cc0056_00_na_children_f_d_lsp
    cc0057_00_na_children_m_p = 0x2174491748de9c21, //cc0057_00_na_children_m_p
    cc0057_00_na_children_m_p_lsp = 0x585ec84e3fb9ede9, //cc0057_00_na_children_m_p_lsp
    cc0058_00_vi_young_m_c = 0x221c4612dc012a6c, //cc0058_00_vi_young_m_c
    cc0058_00_vi_young_m_c_cfl_m = 0xdcabe5d07f55d40c, //cc0058_00_vi_young_m_c_cfl_m
    cc0058_00_vi_young_m_c_wld_m = 0x350ed531e31275ae, //cc0058_00_vi_young_m_c_wld_m
    cc0058_00_vi_young_m_c_lsp = 0x6b30e242dfbb103c, //cc0058_00_vi_young_m_c_lsp
    cc0058_00_vi_young_m_c_item = 0xe5941d7800382342, //cc0058_00_vi_young_m_c_item
    cc0058_00_vi_young_m_c_item2 = 0x52d182e85f643750, //cc0058_00_vi_young_m_c_item2
    cc0059_00_vi_young_f_c = 0x63ad2f673544de1e, //cc0059_00_vi_young_f_c
    cc0059_00_vi_young_f_c_cfl_f = 0x0ac16546b76840cb, //cc0059_00_vi_young_f_c_cfl_f
    cc0059_00_vi_young_f_c_wld_f = 0x987a009a9dbcf2dd, //cc0059_00_vi_young_f_c_wld_f
    cc0059_00_vi_young_f_c_kmn_f = 0xc4a58a3851b96b36, //cc0059_00_vi_young_f_c_kmn_f
    cc0059_00_vi_young_f_c_lsp = 0xa329a685fd1ca4be, //cc0059_00_vi_young_f_c_lsp
    cc0059_00_vi_young_f_c_item = 0x0faf49834ecb8454, //cc0059_00_vi_young_f_c_item
    cc0060_00_na_children_m_d = 0x720fbad0c23eecbb, //cc0060_00_na_children_m_d
    cc0060_00_na_children_m_d_lsp = 0x9c62ae9dce3bb07b, //cc0060_00_na_children_m_d_lsp
    cc0061_00_na_children_f_p = 0xb782ef714e6fa48f, //cc0061_00_na_children_f_p
    cc0061_00_na_children_f_p_lsp = 0x7ea69fc0ce25ee4f, //cc0061_00_na_children_f_p_lsp
    cc0062_00_vi_middle_f_c = 0x712079304f9b76a3, //cc0062_00_vi_middle_f_c
    cc0062_00_vi_middle_f_c_cfl_f = 0x1c3bdac27f5849f2, //cc0062_00_vi_middle_f_c_cfl_f
    cc0062_00_vi_middle_f_c_wld_f = 0x07a767614196fc44, //cc0062_00_vi_middle_f_c_wld_f
    cc0062_00_vi_middle_f_c_lsp = 0x1e6469dc3e880e83, //cc0062_00_vi_middle_f_c_lsp
    cc0063_00_vi_children_m_b = 0xfcbca73fe7894be6, //cc0063_00_vi_children_m_b
    cc0063_00_vi_children_m_b_lsp = 0xe536ebdf19cc8c26, //cc0063_00_vi_children_m_b_lsp
    cc0063_00_vi_children_m_b_lsp_bft = 0xb2a610a35d5b5649, //cc0063_00_vi_children_m_b_lsp_bft
    cc0064_00_vi_children_m_c = 0xa50b412511c6086e, //cc0064_00_vi_children_m_c
    cc0064_00_vi_children_m_c_lsp = 0x0c8a5b5444ac576e, //cc0064_00_vi_children_m_c_lsp
    cc0064_00_vi_children_m_c_lsp_bft = 0x4c9001a953155fc1, //cc0064_00_vi_children_m_c_lsp_bft
    cc0065_00_vi_children_m_d = 0x76c4a0d26345c56e, //cc0065_00_vi_children_m_d
    cc0065_00_vi_children_m_d_lsp = 0xf20985495dd2646e, //cc0065_00_vi_children_m_d_lsp
    cc0066_00_00_vi_old_f_b = 0x8c1e6987bdf9df35, //cc0066_00_00_vi_old_f_b
    cc0066_00_00_vi_old_f_b_lsp = 0xd2e3548093d65dbd, //cc0066_00_00_vi_old_f_b_lsp
    cc0066_00_00_vi_old_f_b_item = 0x331c7da4d45ab57d, //cc0066_00_00_vi_old_f_b_item
    cc0067_00_vi_middle_f_a_item = 0x4c663ca9b09dc32e, //cc0067_00_vi_middle_f_a_item
};
