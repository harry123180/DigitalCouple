# 导入opencv工具包
import cv2
# 导入numpy
import numpy as np
# 导入姿势识别器
from poseutil import PoseDetector

# 打开视频文件
cap = cv2.VideoCapture(0)
# 姿势识别器
detector = PoseDetector()



while True:
    # 读取摄像头，img为每帧图片
    success, img = cap.read()
    if success:
        h, w, c = img.shape
        # 识别姿势
        img = detector.find_pose(img, draw=True)
        # 获取姿势数据
        positions = detector.find_positions(img)

        if positions:
            # 获取仰卧起坐的角度
            angle = detector.find_angle(img, 14, 12, 24)
            print(angle)



        # 打开一个Image窗口显示视频图片
        cv2.imshow('Image', img)

    else:
        # 视频结束退出
        break

    # 如果按下q键，程序退出
    key = cv2.waitKey(1)
    if key == ord('q'):
        break

# 关闭摄像头
cap.release()
# 关闭程序窗口
cv2.destroyAllWindows()
