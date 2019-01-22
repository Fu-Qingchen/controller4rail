# 项目描述

> 年前完成

## 母机

### 实时折线图

### 轨距检测

钢轨顶面 $16mm$ 以下处两工作边轮轨接触点之间的最短距离 

![1547776083095](C:/Users/Administrator/AppData/Roaming/Typora/typora-user-images/1547776083095.png)

| 项目 |  标准  | 精度要求 |
| :--: | :----: | :------: |
| 轨距 | $1435$ | $\pm0.8$ |

- 输入：测距轮读数
- 输出：判断是否合格，图形化显示

### 超高检测

**曲线地段**外轨顶面与内轨顶面水平高度差

![1547776069843](C:/Users/Administrator/AppData/Roaming/Typora/typora-user-images/1547776069843.png)

| 项目 | 标准 | 精度要求 |
| :--: | :--: | :------: |
| 超高 | $0$  | $\pm1.5$ |

- 输入：倾角仪
- 方法：计算出倾角即可，然后转换为高度
- 输出：找出铁轨当前倾角，计算高低误差，图形化显示
- 目前问题：
  - 设定开始时间
  - 计算倾角
  - 导出数据

> 这种方法误差比较大

### 轨向检测

测定钢轨内侧轨距点垂直于轨道方向偏离轨矩点平均位置的偏差

![1547776355231](C:/Users/Administrator/AppData/Roaming/Typora/typora-user-images/1547776355231.png)

| 项目 | 标准 | 精度要求 |
| :--: | :--: | :------: |
| 轨向 | $0$  | $\pm1.5$ |

- 输入：倾角仪加速度值
- 方法：数值积分求取
- 相关教程：http://www.starlino.com/imu_guide.html
- 目前问题：
  - 数据的记录，存储与调用
  - 数值积分
  - 精度的提高

### 高低检测

一股钢轨踏面上在垂直方向上的不平顺程度

![1547776404516](C:/Users/Administrator/AppData/Roaming/Typora/typora-user-images/1547776404516.png)

| 项目 | 标准 | 精度要求 |
| :--: | :--: | :------: |
| 高低 | $0$  | $\pm1.5$ |

目前问题：

- 数据的记录，存储与调用
- 数值积分
- 精度的提高

### 误差减小

- 相关教程
  - https://blog.csdn.net/zdy0_2004/article/details/44758855 

# 通信模块

# GPS模块

- https://blog.csdn.net/kkkkkxiaofei/article/details/8645856
- https://blog.csdn.net/wangzhen209/article/details/51953623