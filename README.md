# BlazorWebassemblyMultiPagesTab
最近准备用Blazor Webassembly做后台开发要用到多标签页,找了半天发现绝大多数都是Blazor Server的多标签没有Webassembly.没办法只能自己想办法造轮子了.
查了许多资料最后还是决定用iframe来实现,不过标签切换等逻辑是用c#代码实现的.

基本功能已经都实现了不论是标签滚动、激活、左移、右移、关闭其他，还是在内容页跳转、新增、关闭标签都有实现。
已经可以用来做实际项目
