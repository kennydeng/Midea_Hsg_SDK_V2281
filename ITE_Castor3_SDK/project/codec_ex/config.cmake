#
# Automatically generated by config: don't edit
# Platform version: VERSION
# Fri Sep 07 15:53:49 2012
#

#
# System
#
# CFG_CPU_FA626 is not set
set(CFG_CPU_SM32 TRUE)
set(CFG_CPU_BIG_ENDIAN TRUE)
# CFG_CPU_LITTLE_ENDIAN is not set
# CFG_CHIP_REV_A0 is not set
set(CFG_CHIP_REV_A1 TRUE)
# CFG_CHIP_PKG_IT9072 is not set
# CFG_CHIP_PKG_IT9075 is not set
# CFG_CHIP_PKG_IT9076 is not set
# CFG_CHIP_PKG_IT9077 is not set
set(CFG_CHIP_PKG_IT9078 TRUE)
set(CFG_RAM_SIZE "0x4000000")
set(CFG_RAM_INIT_SCRIPT "IT9079A1_Initial_DDR2_Mem_tiling_pitch2048_320MHZ.scr")
# CFG_WATCHDOG_ENABLE is not set
set(CFG_ROM_COMPRESS TRUE)
# CFG_DCPS_ENABLE is not set
# CFG_DPU_ENABLE is not set
# CFG_SPREAD_SPECTRUM_PLL1_ENABLE is not set
# CFG_SPREAD_SPECTRUM_PLL2_ENABLE is not set
# CFG_SPREAD_SPECTRUM_PLL3_ENABLE is not set

#
# Screen
#
# CFG_LCD_ENABLE is not set

#
# Graphics
#
# CFG_CMDQ_ENABLE is not set
# CFG_JPEG_HW_ENABLE is not set
set(CFG_FONT_CONF "57-dejavu-sans")
# CFG_UI_ENC_ENABLE is not set

#
# Audio
#
set(CFG_AUDIO_ENABLE TRUE)
set(CFG_AUDIO_DAC_MODULE "ite9070")
set(CFG_AUDIO_CODEC_AACDEC TRUE)
# CFG_AUDIO_CODEC_AC3DEC is not set
# CFG_AUDIO_CODEC_AC3SPDIF is not set
set(CFG_AUDIO_CODEC_AMR TRUE)
set(CFG_AUDIO_CODEC_EAC3DEC TRUE)
set(CFG_AUDIO_CODEC_MP3DEC TRUE)
# CFG_AUDIO_CODEC_MP3DEC_FLASH is not set
set(CFG_AUDIO_CODEC_WAV TRUE)
set(CFG_AUDIO_CODEC_WMADEC TRUE)
set(CFG_AUDIO_CODEC_FLACDEC TRUE)
set(CFG_RISC_TS_DEMUX_PLUGIN TRUE)
set(CFG_AUDIO_CODEC_SBC TRUE)

#
# Video
#
# CFG_VIDEO_ENABLE is not set
# CFG_TS_DEMUX_ENABLE is not set

#
# Storage
#
# CFG_NAND_ENABLE is not set
# CFG_NOR_ENABLE is not set
# CFG_SD0_ENABLE is not set
# CFG_SD1_ENABLE is not set
# CFG_CF_ENABLE is not set
# CFG_MS_ENABLE is not set
# CFG_XD_ENABLE is not set
# CFG_RAMDISK_ENABLE is not set
# CFG_USB0_ENABLE is not set
# CFG_USB1_ENABLE is not set

#
# File System
#
set(CFG_PRIVATE_DRIVE "A")
set(CFG_PUBLIC_DRIVE "B")
set(CFG_FILE_DECRYPT_KEY "0")

#
# Peripheral
#
# CFG_RTC_ENABLE is not set
set(CFG_RTC_DEFAULT_TIMESTAMP "1325376000")
# CFG_I2C0_ENABLE is not set
# CFG_SPI_ENABLE is not set
# CFG_UART0_ENABLE is not set
# CFG_UART1_ENABLE is not set
# CFG_IRDA_ENABLE is not set
# CFG_IR_ENABLE is not set
# CFG_KEYPAD_ENABLE is not set
# CFG_BATTERY_ENABLE is not set
# CFG_GSENSOR_ENABLE is not set
# CFG_HEADSET_ENABLE is not set
# CFG_SPEAKER_ENABLE is not set
# CFG_AMPLIFIER_ENABLE is not set
# CFG_LED_ENABLE is not set

#
# Power
#
# CFG_POWER_ON is not set
# CFG_POWER_STANDBY is not set
# CFG_POWER_SLEEP is not set

#
# GPIO
#

#
# Network
#
# CFG_NET_ENABLE is not set

#
# Task
#

#
# Debug
#
# CFG_DBG_NONE is not set
set(CFG_DBG_PRINTBUF TRUE)
# CFG_DBG_SWUART is not set
set(CFG_DBG_INIT_SCRIPT "IT9070_Initial_DDR2_Mem_tiling_pitch2048_320MHZ.TXT")
set(CFG_DBG_ICE_SCRIPT "IT9070_Initial_DDR2_Mem_tiling_pitch2048_320MHZ.csf")
set(CFG_DBG_PRINTBUF_SIZE "0x1000")
# CFG_DBG_MEMLEAK is not set
# CFG_DBG_RMALLOC is not set
# CFG_DBG_STATS is not set

#
# Upgrade
#
# CFG_UPGRADE_BOOTLOADER is not set
# CFG_UPGRADE_IMAGE is not set
# CFG_UPGRADE_DATA is not set
set(CFG_UPGRADE_ENC_KEY "0")
set(CFG_UPGRADE_FILENAME "ITEPKG03.PKG")

#
# SDK
#
set(CFG_BUILD_RELEASE TRUE)
# CFG_BUILD_DEBUG is not set
set(CFG_VERSION_MAJOR "0")
set(CFG_VERSION_MINOR "1")
set(CFG_VERSION_PATCH "0")
set(CFG_VERSION_CUSTOM "0")
set(CFG_SYSTEM_NAME "ITE Castor3")
# CFG_GENERATE_DOC is not set

#
# Drivers
#

#
# Libraries
#

#
# OpenRTOS
#
# CFG_GCC_LTO is not set
# CFG_OPENRTOS_MEMPOOL_ENABLE is not set
