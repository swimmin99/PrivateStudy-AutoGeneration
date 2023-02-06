<div align="center">
  
![header](https://capsule-render.vercel.app/api?type=rect&height=250&color=auto&text=Auto%20Generation%20Study&fontColor=auto)
![header](https://capsule-render.vercel.app/api?type=rect&height=50&color=ebf3f5&text=UNITY&fontColor=000000&fontSize=20)
![header](https://capsule-render.vercel.app/api?type=rect&height=50&color=ebf3f5&text=2022.1.29~2022.2.03&fontColor=000000&fontSize=15)
  
<div align="left">

```
  📌  최종 목표 : 자동 생성되는 빌딩 블록(Building Cluster)을 만들어보자.
  ☑️  유형 : 개인 프로젝트
  ☑️  사용 기술 : C#, Unity
  💡  기대 : 자동 생성의 이해를 바탕으로 빠른 컨텐츠 생성
  💔  예상 장애 요소 : 복잡한 스크립트 사이의 참조와 상속 관계, 랜덤 구현 방법
 
  Objective : Create Randomly Generated Building Clusters using C# UNity.
  Private Project, using C# and Unity
  Might be able to reduce time consumption in making contents of 3d scene.
  Might bump in to obstacles due to complicated C# scripts.
```
  
<div align="center">
<br>
  
  ![header](https://capsule-render.vercel.app/api?type=rect&height=50&color=ebf3f5&text=DEV%20SCHEDULE&fontColor=000000&fontSize=15)

  
 
|날짜|차시|로그|참고자료(Credits)|코드|
|---|---------|---------|----|-----|
|2023-01-21|1|BuildingGeneration| [Module base Random Building Generation](https://www.youtube.com/watch?v=EWnLKpkJzVQ)|
|2022-01-28|2|PerlinNoise|[Article1](https://www.scratchapixel.com/lessons/procedural-generation-virtual-worlds/procedural-patterns-noise-part-1/introduction.html) <br> [Article2](https://www.scratchapixel.com/lessons/procedural-generation-virtual-worlds/perlin-noise-part-2/perlin-noise.html)||
|2022-01-29|3|PlayerController|[Matt MirrorFish's Procedural City](https://www.youtube.com/watch?v=LHBR1Jfoh74&t=131s)|[BuildingClusterGenerator](https://github.com/swimmin99/PrivateStudy-AutoGeneration/blob/main/BuildingGeneratorNoiseInput.cs)<br>[GridSpawner](https://github.com/swimmin99/PrivateStudy-AutoGeneration/blob/main/GridSpawner.cs)|

  
  <br>
  
  ![header](https://capsule-render.vercel.app/api?type=rect&height=50&color=ebf3f5&text=DEV%20LOG&fontColor=000000&fontSize=15)

  
---
</div>
<div align="left">

<u><strong>단일 빌딩 블록 생성 (Single Building Generation)</strong></u>
  

```
📌목표 : 모듈화 된 모델들을 이용하여 랜덤한 모습의 빌딩을 생성한 후 이를 도시의 모습으로 배치하기
세부목표1 : 랜덤하게 모듈을 합체하는 스크립트를 만들 것.
세부목표2 : 만든 도시를 랜덤한 블록으로 생성하는 스크립트를 만들 것.
```

  
<div align="center">
  <img src ="https://user-images.githubusercontent.com/109887066/217010609-e9002c98-d8fb-461a-b2f9-e81ff4530f08.gif" width="50%" height="50%"/>
  
  ```단일 블록 빌딩을 구현한 후 맵의 랜덤 위치에 생성하여 이동```
  
   <img src ="https://user-images.githubusercontent.com/109887066/217005058-e2df23f0-dc06-4b53-968f-290b73274b26.gif" width="50%" height="50%"/>

  ```Reference에서 본 것과 같이 군집을 통해 도시를 생성할 수 있음```<br> 
    <img src ="https://user-images.githubusercontent.com/109887066/217006678-8fa54ee9-0d2f-4f7e-9222-1db24320e51c.png" width="60%" height="60%"/>

  ```완성된 빌딩 블록(단일 군집)```


<div align="left">


```
💡발전한 점
1.효율적으로 모듈화 된 모델을 통해 배경 오브젝트를 생성하는 방식을 배움
2.오브젝트 자동 생성 방식을 구사할 수 있게 됨.
3.싱글톤을 이해할 수 있었으며 싱글톤으로 만들어진 스크립트를 해체하는 방법을 이해하였다.

📝앞으로의 방향
1.빌딩을 제외하고 랜덤 또는 절차적으로 생성할 수 있는 오브젝트가 무엇이 있을지 생각 해 본다.
2.참고 자료를 잘 복습하여 자료가 없어도 스스로 스크립팅이 가능하도록 체화시켜 본다.
```
  
  
---

    
```
💡느낀점 : 모듈화 된 모델들을 조합하여 오브젝트를 생성하는 것은 획기적이다.
다만 PerlinNoise를 활용한 Generation을 완전히 이해하였다고 보긴 어렵다.
또한 참고자료에서 사용한 객체 생성 방식 싱글톤 방식을 접해보았으며
싱글톤의 특징과 C#으로의 구현 방법을 살펴보았다.
싱글톤에 대해 더 알아봐야 할 필요가 있을 것으로 보인다.
  
  Overall : Using modular models for object creation is phenomenal.
  However haven't fully understood mechanic of Perlin Noise in procedule creation.
  Looked over how to script using sigletone as a programming technique.
  
  다음 스텝 : Perlin Noise를 상세히 설명한 자료 찾기. 싱글톤에 대해 자세히 알아보기.
  Next step would be learning more about Perlin Noise and use singltone in programming.
```
  
