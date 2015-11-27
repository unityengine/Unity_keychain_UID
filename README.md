UID说明:
	
	UID适合于每个平台
	UID整合了unity自带获取唯一标示符，keyChain存储id，IDFA以及IDFV
	提供获取更新删除接口
	IOS Build必须执行以下步骤：
	1.Unity Build版本
	2.拷贝或者新建一个KeychainAccessGroups.plist
	如果新建：
	在工程目录下新建一个KeychainAccessGroups.plist文件，该文件的结构中最顶层的节点必须是一个名为“keychain-access-groups”的Array，
		并且该Array中每一项都是一个描述分组的NSString。yourAppID.com.yourCompany.whatever就是你要起的公共区名称，除了whatever字段可以随便定之外，
		其 他的都必须如实填写。这个文件的路径要配置 在 Project->build setting->Code Signing Entitlements里，否则公共区无效，配置好后， 须用你正式的证书签名编译才可通过，
		否则xcode会弹框告诉你code signing有问题。所以，苹果限制了你只能同公司的产品共享 KeyChain数据，别的公司访问不了你公司产品的KeyChain。
		如果拷贝：则将UID文件夹下面的KeychainAccessGroups.plist拷贝到同级于工程目录,并拖曳到xcode工程窗口修改响应的yourAppID.com.yourCompany.whatever
	3.追加Build Phases->Compile Sources下面的SvUDIDTools.m文件配置信息字符串“-fno-objc-arc”
	4.追加Frameworks－>AdSupport提供给IDFA
	5.修改Build Setting－>Code Signing－>Code Signing Entitlements属性为KeychainAccessGroups.plist
	6.如果文件还报ARC错误请参ARC解决方案
	7.特别注意yourAppID 是发行商id，一个账号对应多个app，但只有一个yourAppID，10位的