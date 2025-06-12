﻿using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;

namespace OWNproject
{

    public class PlayerControllerV2 : MonoBehaviour
    {

        Rigidbody2D characterRb;
        [Header("Values")]
        public float moveSpeed;
        public float jumpPower = 10f;
        public float dashPower = 8f;
        float h;
        bool isGround;
        bool isJumping;
        public int dashCount = 0;
        bool canExtraJump;
        int mouseOnHit = 0;
        // public GameObject[] animObjects;
        [Header("Sprite Controller")]
        public SpriteRenderer[] renderers;

        private void Start()
        {
            characterRb = GetComponent<Rigidbody2D>();

            renderers = GetComponentsInChildren<SpriteRenderer>();    // 자식 오브젝트 안에서 스프라이트 렌더러를 가진 애들을 렌더러 변수에 가져오겠다
                                                                      // 즉, 이 코드로 유니티가 자동으로 넣어줄거라서 따로 물리적으로 가져올 필요 없음.
        }

        // Update is called once per frame
        void Update()
        {
            h = Input.GetAxis("Horizontal"); // 키 입력 받기 a,d,←,→
                                             // v = Input.GetAxis("Vertical"); // 키 입력 받기 w,s,↑,↓

            CharacterJump();
            CharacterFlipInJump();


        }

        private void FixedUpdate()
        {
            CharacterMove();
        }

        /// <summary>
        ///  캐릭터 움직임에 따라 이미지의 Flip 상태가 변하는 코드가 들어있는 함수 CharacterMove()
        /// </summary>

        void CharacterMove()
        {
            // 트랜스폼 이동
            // transform.position ~
            // transform.Translate(~)

            if (!isGround)
                return;


            if (h != 0) // 움직일 때, 이면서 지면에 캐릭터가 닿아있을 때.
            {
                renderers[0].gameObject.SetActive(false); // Idle
                renderers[1].gameObject.SetActive(true); // Run


                //물리적 이동(리지드 바디), but 이건 FixedUpdate에 넣어야함.
                //근데 이동은 둘째치고 키 입력도 FixedUpdate에서 해버리면 인풋 반응이 상대적으로 느려짐.
                characterRb.linearVelocityX = h * moveSpeed;

                if (h > 0)
                {
                    renderers[1].flipX = false; // 플립이 축 뒤집기, 즉 스프라이트에선 방향 전환임.
                    renderers[0].flipX = false; // 근데 왼쪽으로 움직이다 멈췄을 때 오른쪽 보고 서있으면 이상하니까 둘 다 값을 바꿔준다는 개념.
                    renderers[2].flipX = false;
                }
                else if (h < 0)
                {
                    renderers[1].flipX = true;
                    renderers[0].flipX = true;
                    renderers[2].flipX = true;
                }


            }
            else if (h == 0) // 움직이지 않을 때.
            {
                renderers[0].gameObject.SetActive(true); // Idle
                renderers[1].gameObject.SetActive(false); // Run
                renderers[2].gameObject.SetActive(false); // Jump
            }
        }

        void CharacterJump()
        {
            if (isJumping == false)
            {
                // if (Input.GetButtonDown("Jump")) // 겟키다운 스페이스바랑 같은 개념
                if (Input.GetButtonDown("Vertical"))
                {
                    characterRb.AddForceY(jumpPower, ForceMode2D.Impulse);
                    isJumping = true;

                }

            }
            if (canExtraJump == true && isJumping == true && Input.GetButtonDown("Vertical"))
            {
                characterRb.linearVelocityY = 0;
                characterRb.AddForceY(jumpPower, ForceMode2D.Impulse);
                canExtraJump = false;
                dashCount = 0;
            }
        }

        void CharacterFlipInJump()
        {
            if (isGround == true)
                return;

            if (isGround == false && h != 0 && isJumping == true)
            {
                if (h > 0)
                {
                    renderers[2].flipX = false;
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        characterRb.AddForceX(dashPower, ForceMode2D.Impulse);
                        if (dashCount < 2)
                        {
                            dashCount++;
                        }
                        else
                        {
                            canExtraJump = true;
                            dashCount = 0;
                        }
                    }
                }
                else if (h < 0)
                {
                    renderers[2].flipX = true;
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        characterRb.AddForceX(-dashPower, ForceMode2D.Impulse);
                        if (dashCount < 2)
                        {
                            dashCount++;
                        }
                        else
                        {
                            canExtraJump = true;
                            dashCount = 0;
                        }
                    }
                }
            }
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Ground"))
            {
                isGround = true;
                renderers[2].gameObject.SetActive(false); // Jump
                isJumping = false;
                dashCount = 0;
                canExtraJump = false;
            }
        }

        private void OnCollisionExit2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Ground"))
            {
                isGround = false;
                renderers[2].gameObject.SetActive(true); // Jump
                renderers[1].gameObject.SetActive(false);
                renderers[0].gameObject.SetActive(false);
            }
        }
    }



}



