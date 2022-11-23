﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// 有关程序集的一般信息由以下
// 控制。更改这些特性值可修改
// 与程序集关联的信息。
[assembly: AssemblyTitle("Netconf")]

[assembly: AssemblyDescription("" +
    "2022.11.23 解决了XML脚本调试编写窗口卡死的问题" + "\r\n" +
    "2022.11.17 新增告警抑制功能，告警模块右键可找到" + "\r\n" +
     "2022.11.02 新增pop_push的VLAN动作" + "\r\n" +
     "2022.11.02 更新联通新的历史性能全量查询方式" + "\r\n" +
     "2022.10.27 优化业务详细信息，增加环回配置" + "\r\n" +
    "2022.10.26 优化XML脚本调试返回显示双击支持查看对比原始XML数据" + "\r\n" +
    "2022.10.25 新增log查找功能" + "\r\n" +
    "2022.10.25 LLDP、Peer通知修改完成" + "\r\n" +
    "2022.10.24 告警、保护组、属性变更、通用通知已经实现新方案接收订阅通知，其他的待完善..." + "\r\n" +
    "2022.10.21 解决自动化测试通知导致判断用例通过错误的问题，也解决了通知漏报的问题" + "\r\n" +
    "2022.10.20 新增双击业务查询显示CTP详细信息" + "\r\n" +
    "2022.08.30 解决移动EOS业务服务映射模式没有更新问题" + "\r\n" +
    "2022.06.26 尝试解决通知与回复模块的问题" + "\r\n" +
    "2022.06.20 解决通知与应答模块冲突问题" + "\r\n" +
    "2022.06.16 增加循环执行自动化用例" + "\r\n" +
    "2022.05.30 修改了性能模块的功能增加了全部周期" + "\r\n" +
    "2022.05.20 新增告警查询模块" + "\r\n" +
    "2022.05.15 解决下业务包NNI2保护节点错误的问题" + "\r\n" +
    "2022.05.14 新增梳理业务与全部删除业务功能" + "\r\n" +
    "2022.05.13 新增Telnet 删除残余配置功能,可能还相对不完善" + "\r\n" +
    "2022.05.11 新增自动化测试一键替换所有ip地址" + "\r\n" +
    "2022.05.09 新增设备保护组查询和操作,新增日志文件记录功能，方便定位问题" + "\r\n" +
    "2022.05.08 新增文件管理功能,新增时间设置查询功能,新增MC-Port配置和查询" + "\r\n" +
    "2022.05.08 新增板卡复位和删除功能" + "\r\n" +
    "2022.05.03 新增用户密码修改" + "\r\n" +
    "2022.05.02 新增电信MSP和OCH保护组创建" + "\r\n" +
    "2022.05.02 去掉EoOSU业务下发服务映射模式" + "\r\n" +
    "2022.04.27 解决创建OSU 透传业务cir pir不对问题" + "\r\n" +
    "2022.04.26 解决创建所有业务选择保护下发脚本不生效问题" + "\r\n" +
    "2022.04.24 解决了md-name下发错误问题" + "\r\n" +
    "2022.04.23 解决了透传OSU和SDH业务创建失败的问题" + "\r\n" +
    "2022.04.15 新增环回操作、激光器操作、admin接口关闭操作" + "\r\n" +
    "2022.04.14 新增ETH-CTP VLAN等信息修改" + "\r\n" +
    "2022.04.14 新增NTP创建功能，板卡管理支持三大运营商" + "\r\n" +
    "2022.04.10 新增电信 EO-OSU分组业务创建" + "\r\n" +
    "2022.04.10 新增电信、联通、移动ETH业务的 NNI TO NNI 俩种场景业务创建，以及电信保护组查询" + "\r\n" +
    "2022.04.09 新增电信 透传OSU业务创建 和 电信透传ODU业务NNIToNNI场景的业务创建" + "\r\n" +
    "2022.04.07 新增电信 EoO业务创建和OAM业务创建查询" + "\r\n" +
    "2022.04.02 新增电信、联通、移动SDH业务的UNI TO NNI 和NNI TO NNI俩种场景业务创建" + "\r\n" +
    "2022.04.01 新增版本更新信息提示" + "\r\n" +
    "2022.04.01 迁移了SDH业务，未后面融合运营商做准备" + "\r\n" +
    "2022.03.28 新增联通ODU的NNIToNNI业务" + "\r\n" +
    "2022.02.10 新增电信的SDH业务创建" + "\r\n" +
    "2021.12.21 优化了时隙选择，更改未弹窗，支持已被占用的时隙标识" + "\r\n" +
    "2021.12.16 修改自动化测试模块，支持选择是否执行和等待时间" + "\r\n" +
    "2021.12.07 修改业务创建，根据私有命名空间指定净荷类型" + "\r\n" +
    "2021.12.03 新增用户登录认证" + "\r\n" +
    "2021.12.03 自动化功能 支持匹配命名空间" + "\r\n" +
    "2021.12.02 新增EOS业务VCG时隙调整" + "\r\n" +
    "2021.11.26 新增最多32个网元同时上线" + "\r\n" +
    "2021.11.21 新增TCA参数设置" + "\r\n" +
    "2021.11.18 新增ETH-to-ETH业务创建，支持CTP限速调整" + "\r\n" +
    "2021.11.14 新增多个网元同时登录创建使用" + "\r\n" +
    "2021.11.13 新增oduk在线时延测量" + "\r\n" +
    "2021.11.12 新增联通、移动的ODUFlex时隙调整功能" + "\r\n" +
    "2021.11.10 新增联通yang下的业务创建于查询，支持层协议修改和端口信息查询" + "\r\n" +
    "2021.11.04 新增自动化测试功能，导入导出，详细信息查看" + "\r\n" +
    "2021.10.13 新增以太网OAM配置" + "\r\n"+
    "2021.10.12 解决自动模式1.1版本下包含中文计算字节数错误问题" + "\r\n" +
    "2021.09.25 新增NetConf协议版本1.1与1.0自动模式" + "\r\n" +
    "2021.09.23 修改了登录BUG以及异常报错" + "\r\n" +
    "2021.09.20 新增SDH业务创建、保护组查询和操作" + "\r\n" +
    "2021.09.19 新增EOS业务创建（VC4、VC3、VC12）" + "\r\n" +
    "2021.09.17 新增性能统计" + "\r\n"+
    "2021.09.16 新增自动加载互联网在线XML脚本（用户再也不用去找脚本啦）" + "\r\n" +
    "2021.09.15 新增EOO业务创建" + "\r\n" +
    "2021.09.14 新增透传业务创建" + "\r\n" +
    "2021.09.10 新增通知分类处理功能" + "\r\n" +
    "2021.09.05 新增订阅功能" + "\r\n" +
    "2021.09.03 新增netconf客户端工具调试窗口" + "\r\n" +
"")]
[assembly: AssemblyConfiguration("小兔兔配置")]
[assembly: AssemblyCompany("公司网址：hunan128.com")]
[assembly: AssemblyProduct("产品名称：netconf客户端")]
[assembly: AssemblyCopyright("版权所有  ©  胡楠 2021.09.02")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// 将 ComVisible 设置为 false 会使此程序集中的类型
//对 COM 组件不可见。如果需要从 COM 访问此程序集中的类型
//请将此类型的 ComVisible 特性设置为 true。
[assembly: ComVisible(false)]

// 如果此项目向 COM 公开，则下列 GUID 用于类型库的 ID
[assembly: Guid("23e2d8c4-4d81-4dd6-9ad3-169c877955bd")]

// 程序集的版本信息由下列四个值组成: 
//
//      主版本
//      次版本
//      生成号
//      修订号
//
// 可以指定所有值，也可以使用以下所示的 "*" 预置版本号和修订号
// 方法是按如下所示使用“*”: :
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("2022.5.7.37")]
[assembly: AssemblyFileVersion("2022.5.7.37")]
