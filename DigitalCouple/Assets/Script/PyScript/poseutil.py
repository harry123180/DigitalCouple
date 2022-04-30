import cv2
import mediapipe as mp
import math

class PoseDetector():
    '''
    人體姿勢檢測類
    '''
    def __init__(self,
                 static_image_mode=False,
                 upper_body_only=False,
                 smooth_landmarks=True,
                 min_detection_confidence=0.5,
                 min_tracking_confidence=0.5):
        '''
        初始化
        :param static_image_mode: 是否是靜態圖片，預設為否
        :param upper_body_only: 是否是上半身，預設為否
        :param smooth_landmarks: 設定為True減少抖動
        :param min_detection_confidence:人員檢測模型的最小置信度值，預設為0.5
        :param min_tracking_confidence:姿勢可信標記的最小置信度值，預設為0.5
        '''
        self.static_image_mode = static_image_mode
        self.upper_body_only = upper_body_only
        self.smooth_landmarks = smooth_landmarks
        self.min_detection_confidence = min_detection_confidence
        self.min_tracking_confidence = min_tracking_confidence
        # 建立一個Pose物件用於檢測人體姿勢
        self.pose = mp.solutions.pose.Pose(self.static_image_mode, self.upper_body_only, self.smooth_landmarks,
                                           self.min_detection_confidence, self.min_tracking_confidence)

    def find_pose(self, img, draw=True):
        '''
        檢測姿勢方法
        :param img: 一幀影象
        :param draw: 是否畫出人體姿勢節點和連線圖
        :return: 處理過的影象
        '''
        imgRGB = cv2.cvtColor(img, cv2.COLOR_BGR2RGB)
        # pose.process(imgRGB) 會識別這幀圖片中的人體姿勢資料，儲存到self.results中
        self.results = self.pose.process(imgRGB)
        if self.results.pose_landmarks:
            if draw:
                mp.solutions.drawing_utils.draw_landmarks(img, self.results.pose_landmarks,
                                                          mp.solutions.pose.POSE_CONNECTIONS)
        return img

    def find_positions(self, img):
        '''
        獲取人體姿勢資料
        :param img: 一幀影象
        :param draw: 是否畫出人體姿勢節點和連線圖
        :return: 人體姿勢資料列表
        '''
        # 人體姿勢資料列表，每個成員由3個數位組成：id, x, y
        # id代表人體的某個關節點，x和y代表座標位置資料
        self.lmslist = []
        if self.results.pose_landmarks:
            for id, lm in enumerate(self.results.pose_landmarks.landmark):
                h, w, c = img.shape
                cx, cy = int(lm.x * w), int(lm.y * h)
                self.lmslist.append([id, cx, cy])

        return self.lmslist

    def find_angle(self, img, p1, p2, p3, draw=True):
        '''
        獲取人體姿勢中3個點p1-p2-p3的角度
        :param img: 一幀影象
        :param p1: 第1個點
        :param p2: 第2個點
        :param p3: 第3個點
        :param draw: 是否畫出3個點的連線圖
        :return: 角度
        '''
        x1, y1 = self.lmslist[p1][1], self.lmslist[p1][2]
        x2, y2 = self.lmslist[p2][1], self.lmslist[p2][2]
        x3, y3 = self.lmslist[p3][1], self.lmslist[p3][2]

        # 使用三角函數公式獲取3個點p1-p2-p3，以p2為角的角度值，0-180度之間
        angle = int(math.degrees(math.atan2(y1-y2, x1-x2) - math.atan2(y3-y2, x3-x2)))
        if angle < 0:
            angle = angle + 360
        if angle > 180:
            angle = 360 - angle

        if draw:
            cv2.circle(img, (x1, y1), 8, (0, 255, 255), cv2.FILLED)
            cv2.circle(img, (x2, y2), 15, (255, 0, 255), cv2.FILLED)
            cv2.circle(img, (x3, y3), 8, (0, 255, 255), cv2.FILLED)
            cv2.line(img, (x1, y1), (x2, y2), (255, 255, 255, 3))
            cv2.line(img, (x2, y2), (x3, y3), (255, 255, 255, 3))
            #cv2.putText(img, str(angle), (x2-50, y2+50),cv2.FONT_HERSHEY_SIMPLEX, 2, (0, 255, 255), 2)

        return angle