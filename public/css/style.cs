html:root {
  font-size: 10px;
}

ul, li, h1, h2, h3, h4, p, label {
  margin: 0;
  padding: 0;
}

body {
  font-family: "Poppins";
}

section {
  padding: 0 19.5rem;
}
@media (max-width: 375px) {
  section {
    padding: 0 1.5rem;
  }
}

.title-first {
  color: #fff;
  font-size: 6.4rem;
  font-weight: 600;
  line-height: 82px;
  letter-spacing: 0;
}
@media (max-width: 375px) {
  .title-first {
    font-size: 4.8rem;
    line-height: 62px;
  }
  .title-first br {
    display: none;
  }
}
.title-first span {
  color: #FFC924;
}

.title-secondary {
  font-size: 3.8rem;
  font-weight: 800;
  color: #0B2239;
  line-height: 4rem;
  text-transform: uppercase;
}
@media (max-width: 375px) {
  .title-secondary {
    font-size: 3rem;
  }
}

.title-third {
  color: #0B2239;
  font-size: 2.4rem;
  font-weight: 800;
  text-transform: uppercase;
}

.descr {
  color: #0B2239;
  font-size: 1.6rem;
  line-height: 2.6rem;
}

.subtitle {
  color: #fff;
  font-size: 2.4rem;
}
@media (max-width: 375px) {
  .subtitle {
    font-size: 1.8rem;
  }
}
.subtitle span {
  color: #00B67A;
}

.span-green {
  color: #00B67A;
  font-weight: 700;
}

.span-orange {
  color: #F36B25;
  font-weight: 700;
}

.span-blue {
  color: #1CBFE0;
  font-weight: 700;
}

.span-brown {
  color: #612E21;
  font-weight: 700;
}

.margin-bottom-151px {
  margin-bottom: 15.1rem;
}

.margin-bottom-147px {
  margin-bottom: 14.7rem;
}

.margin-bottom-130px {
  margin-bottom: 13rem;
}

.margin-bottom-100px {
  margin-bottom: 10rem;
}

.margin-bottom-94px {
  margin-bottom: 9.4rem;
}

.margin-bottom-90px {
  margin-bottom: 9rem;
}

.margin-bottom-63px {
  margin-bottom: 6.3rem;
}

.margin-bottom-53px {
  margin-bottom: 5.3rem;
}

.margin-right-40px {
  margin-right: 4rem;
}

.margin-bottom-40px {
  margin-bottom: 4rem;
}

.margin-bottom-39px {
  margin-bottom: 3.9rem;
}

.margin-bottom-34px {
  margin-bottom: 3.4rem;
}

.margin-bottom-30px {
  margin-bottom: 3rem;
}

.margin-bottom-18px {
  margin-bottom: 1.8rem;
}

.margin-right-28px {
  margin-right: 2.8rem;
}

.margin-right-22px {
  margin-right: 2.2rem;
}

.margin-bottom-14px {
  margin-bottom: 1.4rem;
}

.margin-bottom-8px {
  margin-bottom: 0.8rem;
}

@media (max-width: 375px) {
  .mobile-margin-bottom-50px {
    margin-bottom: 5rem;
  }
}

@media (max-width: 375px) {
  .mobile-margin-bottom-44px {
    margin-bottom: 4.4rem;
  }
}

.mobile-display-flex {
  display: none;
}
@media (max-width: 375px) {
  .mobile-display-flex {
    display: flex;
    flex-direction: column;
  }
}

@media (max-width: 375px) {
  .mobile-display-none {
    display: none;
  }
}

.gap-30px {
  gap: 3rem;
}

.df {
  display: flex;
}

.df-jcsb {
  display: flex;
  justify-content: space-between;
}

.flex-wrap-wrap {
  flex-wrap: wrap;
}

.aic {
  align-items: center;
}

.tac {
  text-align: center;
}

.hidden-label {
  display: none;
}

.font-size-48px {
  font-size: 4.8rem;
}

.font-size-24px {
  font-size: 2.4rem;
}

.padding-0-30px {
  padding: 0 3rem;
}

.search-button {
  background: none;
  border: none;
  transition: all 0.3s;
  color: #fff;
  transition: all 0.3s;
  font-size: 1.5rem;
}
@media (max-width: 375px) {
  .search-button {
    margin-right: 2.5rem;
  }
}
.search-button:focus {
  outline: none;
}
.search-button:hover {
  color: #00B67A;
}
.search-button:active {
  color: #fff;
}

.trash-button {
  background: none;
  border: none;
  transition: all 0.3s;
  color: #fff;
  font-size: 1.5rem;
  position: relative;
}
.trash-button-count {
  width: 1.4rem;
  height: 1.4rem;
  color: #0B2239;
  background: #85919C;
  font-size: 1.1rem;
  font-weight: 600;
  border-radius: 50%;
  display: flex;
  align-items: center;
  justify-content: center;
  position: absolute;
  top: 0;
  right: 0;
}
.trash-button-count__active {
  background: #FFC924;
  box-shadow: 0 0 #FFC924;
  display: none;
}
.trash-button:focus {
  outline: none;
}
.trash-button:hover {
  color: #00B67A;
  cursor: pointer;
}
.trash-button:active {
  color: #fff;
}
@media (max-width: 375px) {
  .trash-button {
    margin-right: 0;
  }
}

.sign-in {
  border: 1px solid #FFC924;
  border-radius: 0.7rem;
  background: #2F4357;
  color: #fff;
  font-size: 1.4rem;
  font-weight: 600;
  padding: 1rem 1.7rem;
  box-shadow: inset 0px -5px #0B1D31;
  transition: all 0.3s;
}
.sign-in:focus {
  outline: none;
}
.sign-in:hover {
  color: #00B67A;
  cursor: pointer;
}
.sign-in:active {
  color: #fff;
  box-shadow: none;
}
@media (max-width: 375px) {
  .sign-in {
    display: none;
  }
}

.gold-button {
  background: #FFC924;
  border: none;
  color: #612E21;
  padding: 1.3rem 3.3rem;
  border-radius: 0.7rem;
  font-size: 1.6rem;
  font-weight: 600;
  box-shadow: 0 0.2rem #E4AD03;
  overflow: hidden;
  position: relative;
  transition: all 0.3s;
  text-transform: uppercase;
}
@media (max-width: 375px) {
  .gold-button {
    margin-bottom: 9rem;
  }
}
.gold-button:focus {
  outline: none;
}
.gold-button:hover {
  cursor: pointer;
}
.gold-button:hover::before {
  display: none;
}
.gold-button:active::before {
  display: block;
}
.gold-button span {
  z-index: 1;
  position: relative;
}
.gold-button::before {
  content: " ";
  width: 10.3rem;
  height: 10.3rem;
  background: #fff;
  filter: blur(47px);
  position: absolute;
  top: -50%;
  left: 1.9rem;
  z-index: 0;
}
.gold-button__border {
  background: none;
  border: 1px solid #FFC924;
  padding: 1.3rem 1.5rem 1.3rem 1.7rem;
}
.gold-button__border::before {
  display: none;
}
@media (max-width: 375px) {
  .gold-button__border {
    margin-bottom: 1.5rem;
  }
}

.next-button {
  width: 4rem;
  height: 4rem;
  border: none;
  border-radius: 0.6rem;
  background: #1CBFE0;
  color: #fff;
  font-size: 2rem;
  transition: all 0.3s;
}
.next-button:focus {
  outline: none;
}
.next-button:hover {
  color: #F36B25;
  cursor: pointer;
}
.next-button:active {
  color: #fff;
}

.show-more {
  background: none;
  border: 1px solid #1CBFE0;
  font-size: 1.8rem;
  font-weight: 700;
  padding: 1.8rem 2.5rem;
  border-radius: 0.5rem;
  transition: all 0.3s;
}
.show-more:focus {
  outline: none;
}
.show-more:hover {
  background: #1CBFE0;
  cursor: pointer;
}
.show-more:active {
  background: none;
}
.show-more-container {
  text-align: center;
}

.slider {
  background: none;
  border: none;
  color: #85919C;
  font-size: 4rem;
  transition: all 0.3s;
}
@media (max-width: 375px) {
  .slider {
    display: none;
  }
}
.slider:focus {
  outline: none;
}
.slider:hover {
  color: #0B2239;
}
.slider:active {
  color: #85919C;
}

.blue-button {
  background: #1CBFE0;
  border: none;
  padding: 1.2rem 1.7rem;
  color: #fff;
  font-size: 1.6rem;
  font-weight: 600;
  border-radius: 0.7rem;
  position: relative;
  transition: all 0.3s;
}
.blue-button::before {
  content: " ";
  width: 12rem;
  height: 8rem;
  background: #fff;
  filter: blur(60px);
  top: -1.3rem;
  left: 1.5rem;
  position: absolute;
}
.blue-button:focus {
  outline: none;
}
.blue-button:hover {
  color: #F36B25;
  cursor: pointer;
}
.blue-button:active {
  color: #fff;
}
.blue-button:active::before {
  display: none;
}
@media (max-width: 375px) {
  .blue-button::before {
    display: none;
  }
}

.read-more {
  background: none;
  border: none;
  font-size: 1.2rem;
  line-height: 2.3rem;
  font-weight: 700;
  color: #fff;
  transition: all 0.3s;
}
.read-more:focus {
  outline: none;
}
.read-more:hover {
  color: #1CBFE0;
}
.read-more:active {
  color: #fff;
}

.subscribe {
  background: #2F4357;
  border: 1px solid rgba(255, 255, 255, 0.5);
  border-radius: 0.7rem;
  color: #fff;
  font-size: 1.4rem;
  font-weight: 600;
  padding: 1.5rem 2.1rem;
  box-shadow: 0px 5px #0B1D31;
  transition: all 0.3s;
}
@media (max-width: 375px) {
  .subscribe {
    padding: 1.4rem 1.3rem;
  }
}
.subscribe:focus {
  outline: none;
}
.subscribe:hover {
  border-color: #F36B25;
}
.subscribe:active {
  box-shadow: none;
}

.star-icon {
  background: #00B67A;
  padding: 1.2rem;
  border-radius: 1rem;
}
.star-icon:not(:last-child) {
  margin-right: 0.7rem;
}
@media (max-width: 375px) {
  .star-icon {
    padding: 1rem;
  }
  .star-icon img {
    width: 1.8rem;
    height: 1.8rem;
  }
}

.choose-game-item {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  width: 17rem;
  height: 14rem;
  border: 1px solid rgba(11, 34, 57, 0.2);
  border-radius: 0.7rem;
}
@media (max-width: 375px) {
  .choose-game-item {
    width: 16.5rem;
    height: 13.5rem;
  }
}
.choose-game-item-title {
  color: #0B2239;
  font-size: 1.6rem;
  font-weight: 600;
  line-height: 2.4rem;
}

.tabs {
  display: flex;
  flex-wrap: nowrap;
  gap: 1.9rem;
}
@media (max-width: 375px) {
  .tabs {
    overflow-x: auto;
  }
  .tabs::-webkit-scrollbar {
    display: none;
  }
}
.tabs-item {
  border: 1px solid rgba(11, 34, 57, 0.2);
  padding: 1.3rem 1.5rem;
  font-size: 1.8rem;
  font-weight: 700;
  color: #0B2239;
  background: #fff;
  transition: all 0.3s;
  border-radius: 0.5rem;
}
@media (max-width: 375px) {
  .tabs-item {
    min-width: 16.2rem;
  }
}
.tabs-item:focus {
  outline: none;
}
.tabs-item:hover {
  background: #0B2239;
  color: #fff;
  cursor: pointer;
}
.tabs-item:active {
  background: #fff;
  color: #0B2239;
}

.game-card {
  display: inline-block;
  border-radius: 0.9rem;
  border: 1px solid #E1E4E7;
  width: 36rem;
  height: 49rem;
}
@media (max-width: 375px) {
  .game-card {
    width: 34.5rem;
    height: 47rem;
  }
}
.game-card:nth-child(1) .game-card-img {
  padding: 1.4rem 2.9rem 1.6rem 3.4rem;
}
.game-card:nth-child(1) .game-card-img img {
  width: 29.7rem;
  height: 27.8rem;
}
.game-card:nth-child(5) .game-card-img {
  padding: 1.4rem 2.9rem 1.6rem 3.4rem;
}
.game-card:nth-child(5) .game-card-img img {
  width: 29.7rem;
  height: 27.8rem;
}
.game-card:nth-child(2) .game-card-img {
  padding: 2rem 3.3rem 1.1rem 2.9rem;
}
.game-card:nth-child(2) .game-card-img::before {
  background: #C07372;
}
.game-card:nth-child(2) .game-card-img img {
  width: 29.7rem;
  height: 27.7rem;
}
.game-card:nth-child(6) .game-card-img {
  padding: 2rem 3.3rem 1.1rem 2.9rem;
}
.game-card:nth-child(6) .game-card-img::before {
  background: #C07372;
}
.game-card:nth-child(6) .game-card-img img {
  width: 29.7rem;
  height: 27.7rem;
}
.game-card:nth-child(3) .game-card-img {
  padding: 4.8rem 6.1rem 4.4rem 6.5rem;
}
.game-card:nth-child(3) .game-card-img::before {
  background: #5F2C93;
}
.game-card:nth-child(3) .game-card-img img {
  width: 23.4rem;
  height: 21.8rem;
}
.game-card:nth-child(7) .game-card-img {
  padding: 4.8rem 6.1rem 4.4rem 6.5rem;
}
.game-card:nth-child(7) .game-card-img::before {
  background: #5F2C93;
}
.game-card:nth-child(7) .game-card-img img {
  width: 23.4rem;
  height: 21.8rem;
}
.game-card:nth-child(4) .game-card-img {
  padding: 2.7rem 4.6rem 3.8rem 3.3rem;
}
.game-card:nth-child(4) .game-card-img::before {
  background: #AFAF25;
}
.game-card:nth-child(4) .game-card-img img {
  width: 28rem;
  height: 24.5rem;
}
.game-card:nth-child(8) .game-card-img {
  padding: 2.7rem 4.6rem 3.8rem 3.3rem;
}
.game-card:nth-child(8) .game-card-img::before {
  background: #AFAF25;
}
.game-card:nth-child(8) .game-card-img img {
  width: 28rem;
  height: 24.5rem;
}
.game-card-text {
  padding: 1.2rem 3rem 1.8rem 3rem;
}
.game-card__sale-item {
  background: #539415;
  font-size: 1.2rem;
  font-weight: 600;
  padding: 0.3rem;
  position: absolute;
  left: 8.6rem;
  top: 2rem;
  border-radius: 0.5rem;
}
.game-card__sale-green {
  color: #539415;
  font-size: 2.1rem;
  font-weight: 700;
}
.game-card__sale-sale {
  font-size: 1.4rem;
  font-weight: 600;
  text-decoration: line-through;
  text-decoration-color: #F36B25;
}
.game-card__new-item {
  position: absolute;
  left: 2rem;
  top: 2rem;
  background: #1CBFE0;
  padding: 0.4rem 0.6rem;
  border-radius: 0.5rem;
  font-size: 1.2rem;
  font-weight: 600;
}
.game-card__hot-item {
  background: #F36B25;
  padding: 0.3rem 0.8rem;
  position: absolute;
  left: 2rem;
  top: 2rem;
  border-radius: 0.5rem;
  font-size: 1.2rem;
  font-weight: 600;
}
.game-card-img {
  background: #141414;
  color: #fff;
  position: relative;
  overflow: hidden;
  z-index: 1;
  border-radius: 0.9rem;
  border-bottom-right-radius: 0;
  border-bottom-left-radius: 0;
}
.game-card-img::before {
  content: " ";
  display: block;
  width: 100%;
  height: 29.5rem;
  background: url(../img/game-card/1-bcg.svg) center center no-repeat;
  position: absolute;
  top: 0rem;
  left: 0rem;
  filter: blur(109px);
  z-index: -1;
}
.game-card-title {
  color: #0B2239;
  font-size: 1.8rem;
  font-weight: 700;
  line-height: 2.5rem;
  margin-bottom: 0.4rem;
}
.game-card-list {
  list-style-image: url(../icons/game-card/circle.svg);
  padding-left: 1.4rem;
  margin-bottom: 0.9rem;
}
.game-card-list-item {
  font-size: 1.2rem;
  font-weight: 500;
  line-height: 20px;
}
.game-card-price {
  display: flex;
  justify-content: space-between;
  align-items: end;
}
.game-card-price-text {
  font-size: 1.2rem;
  color: #85919C;
  margin-right: 0.5rem;
}
.game-card-price-number {
  color: #0B2239;
  font-size: 2.1rem;
  font-weight: 600;
  line-height: 1;
}
.game-card-price-block {
  display: flex;
  align-items: end;
}

#newHotCard .game-card__hot-item {
  left: 8.4rem;
}

.how-works-item {
  padding: 6.1rem 4.4rem 6.7rem 9.7rem;
  background: #D8E2EA;
  position: relative;
  z-index: 1;
}
@media (max-width: 375px) {
  .how-works-item {
    padding: 5.5rem 3.9rem 6rem 8.7rem;
  }
}
@media (max-width: 375px) {
  .how-works-item-icon img {
    width: 9.5rem;
    height: 7.9rem;
  }
}
.how-works-item-title {
  font-size: 2.1rem;
  color: #0B2239;
  font-weight: 800;
  margin-bottom: 0.4rem;
}
@media (max-width: 375px) {
  .how-works-item-title {
    font-size: 1.8rem;
    white-space: nowrap;
  }
}
.how-works-item-subtitle {
  color: #85919C;
  font-size: 1.6rem;
}
@media (max-width: 375px) {
  .how-works-item-subtitle {
    white-space: nowrap;
  }
}
.how-works-item-subtitle br {
  display: none;
}
@media (max-width: 375px) {
  .how-works-item-subtitle br {
    display: block;
  }
}
.how-works-item::before {
  content: " ";
  width: 99%;
  height: 98%;
  position: absolute;
  left: 0.2rem;
  top: 0.2rem;
  clip-path: inherit;
  background: #F8FBFF;
  z-index: -1;
}
.how-works-item:nth-child(1) {
  clip-path: polygon(100% 19%, 100% 100%, 0 79%, 0 0);
}
.how-works-item:nth-child(3) {
  clip-path: polygon(100% 19%, 100% 100%, 0 79%, 0 0);
}
.how-works-item:nth-child(2) {
  clip-path: polygon(100% 0, 100% 80%, 0 100%, 0 19%);
}
.how-works-item:nth-child(4) {
  clip-path: polygon(100% 0, 100% 80%, 0 100%, 0 19%);
}

.why-item {
  text-align: center;
  display: inline-block;
}
.why-item-icon {
  margin-bottom: 3.1rem;
}
.why-item-title {
  font-size: 2.4rem;
  color: #0B2239;
  font-weight: 800;
  margin-bottom: 0.9rem;
}
.why-item-subtitle {
  color: #0B2239;
  font-size: 1.8rem;
  width: 32rem;
}

.comment {
  padding: 3.5rem 1.9rem 3.2rem 3rem;
  display: inline-block;
  background: #F8FBFF;
  padding: 3.5rem 1.9rem 3.2rem 3rem;
  min-width: 36rem;
  min-height: 27rem;
}
@media (max-width: 375px) {
  .comment {
    width: 3rem;
    height: 29rem;
    padding: 3.5rem 2.4rem;
  }
}
.comment-icons {
  gap: 0.3rem;
  display: flex;
  margin-bottom: 0.7rem;
}
.comment-icons div {
  padding: 0.5rem;
  display: inline-block;
  border-radius: 0.5rem;
}
.comment-icons div img {
  width: 1rem;
  height: 1rem;
}
.comment-title {
  color: #0B2239;
  font-size: 1.6rem;
  font-weight: 600;
  margin-bottom: 0.3rem;
}
.comment-descr {
  width: 31rem;
  color: rgba(11, 34, 57, 0.7);
  font-size: 1.4rem;
  line-height: 2.4rem;
  margin-bottom: 3rem;
}
.comment-time {
  color: #85919C;
  font-size: 1.4rem;
}
.comment-time span {
  font-weight: 600;
}

.faq-question {
  background: #F8FBFF;
  border: 1px solid #C9DDEF;
  padding: 2.1rem 3rem 3.3rem 3rem;
  border-radius: 0.7rem;
  width: 114rem;
  height: 7rem;
  transition: all 0.3s;
}
@media (max-width: 375px) {
  .faq-question {
    width: 34.5rem;
    height: auto;
    padding: 2.2rem 1.8rem 2.1rem 3rem;
  }
}
.faq-question i {
  transform: rotate(180deg);
}
.faq-question__active {
  height: 12rem;
}
@media (max-width: 375px) {
  .faq-question__active {
    padding: 2rem 2rem 2.5rem 3rem;
    height: 18.5rem;
  }
}
.faq-question__active i {
  transform: rotate(0);
}
.faq-question__active .faq-question-answ {
  display: inline-block;
}
.faq-question-qs {
  display: flex;
  justify-content: space-between;
  font-size: 1.8rem;
  font-weight: 600;
  color: #0B2239;
  margin-bottom: 1.3rem;
}
.faq-question-answ {
  display: none;
  color: #0B2239;
  font-size: 1.6rem;
  line-height: 2.6rem;
}

.faq-support {
  background: #F8FBFF;
  padding: 4.9rem 3rem;
  display: inline-block;
  border-radius: 0.7rem;
}
@media (max-width: 375px) {
  .faq-support {
    margin-bottom: 3rem;
  }
}
.faq-support-title {
  font-size: 2.4rem;
  color: #0B2239;
  font-weight: 800;
  margin-bottom: 1.4rem;
}
.faq-support-descr {
  width: 24rem;
  font-size: 1.6rem;
  line-height: 2.6rem;
  margin-bottom: 1.8rem;
}

.blog-card {
  text-align: center;
  width: 35rem;
  height: 44.7rem;
  border-radius: 0.7rem;
  padding-top: 25.2rem;
  color: #fff;
}
@media (max-width: 375px) {
  .blog-card {
    min-width: 32.5rem;
    min-height: 40rem;
  }
}
.blog-card-title {
  font-size: 1.8rem;
  font-weight: 700;
  line-height: 2.56rem;
  margin-bottom: 1.5rem;
}
.blog-card-descr {
  font-size: 1.4rem;
  line-height: 2.2rem;
  margin-bottom: 1rem;
}

.social-item {
  background: #3C4E61;
  padding: 1.3rem;
  border-radius: 0.5rem;
  font-size: 2rem;
}
.social-item a {
  color: #fff;
}

.aside {
  background: #0B2239;
  display: flex;
  flex-direction: column;
  width: 26rem;
  gap: 1.4rem;
  padding: 5rem 5.4rem 0 5rem;
}
@media (max-width: 375px) {
  .aside {
    display: none;
  }
}
.aside a::after {
  width: 177%;
}

.bread-crumbs {
  display: flex;
  align-items: center;
  color: #0B2239;
  margin-bottom: 4.5rem;
  white-space: nowrap;
}
@media (max-width: 375px) {
  .bread-crumbs {
    overflow-x: auto;
    padding-top: 1.9rem;
  }
  .bread-crumbs::-webkit-scrollbar {
    display: none;
  }
}
.bread-crumbs-back {
  background: none;
  border: none;
  font-size: 1.4rem;
  transition: all 0.3s;
  margin-right: 2rem;
}
.bread-crumbs-back:focus {
  outline: none;
}
.bread-crumbs-back:hover {
  color: #F36B25;
  cursor: pointer;
}
.bread-crumbs-back:active {
  color: #0B2239;
}
.bread-crumbs-link {
  font-size: 1.4rem;
  font-weight: 500;
  transition: all 0.3s;
  margin-right: 2.1rem;
  color: #0B2239;
}
.bread-crumbs-link:focus {
  outline: none;
}
.bread-crumbs-link:hover {
  color: #F36B25;
  cursor: pointer;
  text-decoration: none;
}
.bread-crumbs-link:active {
  color: #0B2239;
}
.bread-crumbs-i {
  font-size: 1.4rem;
  margin-right: 2rem;
}
.bread-crumbs-current {
  font-size: 1.4rem;
}

.tabs-border {
  display: flex;
  align-items: center;
  gap: 6.5rem;
  margin-bottom: 1.6rem;
}
@media (max-width: 375px) {
  .tabs-border {
    gap: 0;
    width: 34.5rem;
    overflow-x: auto;
    margin-bottom: 2.7rem;
  }
  .tabs-border::-webkit-scrollbar {
    display: none;
  }
}
.tabs-border-item {
  padding-bottom: 0.3rem;
  transition: all 0.3s;
}
@media (max-width: 375px) {
  .tabs-border-item {
    white-space: nowrap;
  }
  .tabs-border-item:not(:last-child) {
    margin-right: 3.6rem;
  }
}
.tabs-border-item a {
  color: #85919C;
  font-size: 1.8rem;
  font-weight: 800;
  transition: all 0.3s;
}
.tabs-border-item a:hover {
  cursor: pointer;
  color: #0B2239;
  text-decoration: none;
}
.tabs-border-item a:active {
  color: #85919C;
}
.tabs-border-item__active {
  border-bottom: 3px solid #0B2239;
}
.tabs-border-item__active a {
  color: #0B2239;
  font-size: 1.8rem;
  font-weight: 800;
}

.basket {
  position: absolute;
  right: 19.5rem;
  top: 31.9rem;
  width: 36rem;
}
@media (max-width: 375px) {
  .basket {
    width: 34.5rem;
    right: 1.5rem;
    top: 37.3rem;
  }
}
.basket-content {
  background: #F8FBFF;
  border: 1px solid rgba(0, 0, 0, 0.08);
  margin-bottom: 2rem;
}
.basket-content-img {
  position: relative;
  margin-bottom: 3rem;
}
.basket-content-img img:nth-child(1) {
  width: 100%;
}
.basket-content-img-icon {
  color: #fff;
  font-size: 1.4rem;
  font-weight: 500;
  background: #F36B25;
  padding: 0.3rem 1.2rem;
  display: inline-block;
  border-radius: 0.3rem;
  position: absolute;
  top: 2rem;
  left: 2rem;
}
.basket-content-img-logo {
  position: absolute;
  right: 2rem;
  top: 1.5rem;
}
.basket-content-price {
  margin-bottom: 6rem;
}
.basket-content-text {
  margin-bottom: 3.4rem;
}
.basket-content-text-title {
  color: #85919C;
  font-size: 1.6rem;
  font-weight: 700;
}
.basket-content-text-title:nth-child(1) {
  margin-bottom: 0.5rem;
}
.basket-content-text-title:nth-child(2) {
  font-weight: 600;
  color: #F36B25;
}
.basket-content-title {
  color: #85919C;
  font-size: 1.6rem;
  font-weight: 600;
  margin-bottom: 0.7rem;
  text-transform: uppercase;
}
.basket-content-buttons {
  display: flex;
  flex-wrap: wrap;
}
.basket-content-choose:not(:last-child) {
  margin-bottom: 4rem;
}
.basket-content-choose-button {
  background: none;
  border: 1px solid #B6BDC4;
  color: #0B2239;
  font-size: 1.6rem;
  border-radius: 0.3rem;
  transition: all 0.3s;
}
.basket-content-choose-button:focus {
  outline: none;
}
.basket-content-choose-button:hover {
  border-color: #0B2239;
}
.basket-content-choose-button:active {
  border-color: #B6BDC4;
}
.basket-content-choose-button:not(:last-child) {
  margin-right: 0.9rem;
}
.basket-content-choose-button__active {
  border-color: #0B2239;
  font-weight: 600;
}
.basket-content-choose-button span {
  color: #85919C;
}
.basket-content-choose-buttons {
  color: #0B2239;
  font-size: 1.6rem;
}
.basket-content-choose-buttons label {
  display: flex;
  align-items: center;
  position: relative;
}
.basket-content-choose-buttons label::before {
  content: " ";
  display: inline-block;
  width: 2.2rem;
  height: 2.2rem;
  background: none;
  border-radius: 50%;
  border: 2px solid #B6BDC4;
  margin-right: 1.4rem;
}
.basket-content-choose-buttons label::after {
  content: " ";
  display: inline-block;
  width: 1.6rem;
  height: 1.6rem;
  background: #0B2239;
  border-radius: 50%;
  position: absolute;
  left: 0.3rem;
  opacity: 0;
}
.basket-content-choose-buttons-item {
  display: flex;
  align-items: center;
  justify-content: space-between;
  padding-bottom: 0.7rem;
  border-bottom: 1px solid rgba(11, 34, 57, 0.2);
}
.basket-content-choose-buttons-item:not(:last-child) {
  margin-bottom: 1rem;
}
.basket-content-choose-buttons-item__active {
  font-weight: 600;
}
.basket-content-choose-buttons-input {
  position: absolute;
  opacity: 0;
  cursor: pointer;
}
.basket-content-choose-buttons-input:checked + label::after {
  opacity: 1;
}
.basket-content-choose-buttons-input:checked + label::before {
  border-color: #0B2239;
}
.basket-content-price-block input[type=range i] {
  width: 100%;
  -webkit-appearance: none;
  appearance: none;
  height: 16px;
  background: #FFEBAD;
  border-radius: 8px;
  outline: none;
  padding: 0;
  margin: 0;
}
.basket-content-price-block input[type=range i]::-webkit-slider-thumb {
  -webkit-appearance: none;
  appearance: none;
  width: 1.7rem;
  height: 1.7rem;
  background-color: #FFC924;
  border-radius: 50%;
  cursor: pointer;
  position: relative;
  box-shadow: 0 0 0 1.4rem #FFEBAD;
}
.basket-content-price-block-container {
  margin-bottom: 2rem;
}
.basket-content-price-block-arrow {
  font-size: 1.5rem;
  margin-left: 1.8rem;
  margin-right: 1.5rem;
}
.basket-content-price-block-title {
  color: #85919C;
  font-size: 1.2rem;
  font-weight: 500;
}
.basket-content-price-block-input input {
  background: #FFFCF4;
  border: 1px solid #FFC924;
  border-radius: 0.3rem;
  width: 10rem;
  height: 4rem;
  padding: 0.8rem 0 0.8rem 1rem;
  font-size: 1.6rem;
  color: #0B2239;
  font-weight: 600;
}
.basket-content-price-block-input input::placeholder {
  color: #0B2239;
  font-size: 1.6rem;
  font-weight: 600;
}
.basket-content-price-block-container {
  display: flex;
  align-items: center;
}
.basket-content-check {
  margin-bottom: 5.4rem;
}
.basket-content-check-select {
  position: relative;
  width: 100%;
  height: 4rem;
  background: url(../icons/basket/check-grey.svg) centet center no-repeat;
  background-position-x: 26.7rem;
  background-size: 0.8rem 1.2rem;
  color: #0B2239;
  font-size: 1.6rem;
}
.basket-content-check-select[data-state=active] .basket-content-check-select-title::before {
  transform: translate(-3px, -50%) rotate(-45deg);
}
.basket-content-check-select[data-state=active] .basket-content-check-select-title::after {
  transform: translate(3px, -50%) rotate(45deg);
}
.basket-content-check-select[data-state=active] .basket-content-check-select-content {
  opacity: 1;
}
.basket-content-check-select[data-state=active] .basket-content-check-select-label + .basket-content-check-select-select + .basket-content-check-select-label {
  max-height: 4rem;
  border-top-width: 0.1rem;
}
.basket-content-check-select-title {
  display: flex;
  align-items: center;
  width: 100%;
  height: 100%;
  padding: 8px 16px;
  border-radius: 5px;
  border: solid 1px #c7ccd1;
  cursor: pointer;
}
.basket-content-check-select-title::before, .basket-content-check-select-title::after {
  ontent: "";
  position: absolute;
  top: 50%;
  right: 16px;
  display: block;
  width: 10px;
  height: 2px;
  transition: all 0.3s ease-out;
  background-color: #333333;
  transform: translate(-3px, -50%) rotate(45deg);
}
.basket-content-check-select-title::after {
  transform: translate(3px, -50%) rotate(-45deg);
}
.basket-content-check-select-content {
  position: absolute;
  top: 40px;
  left: 3px;
  display: flex;
  flex-direction: column;
  width: calc(100% - 6px);
  background-color: #ffffff;
  border: 1px solid #c7ccd1;
  border-top: none;
  border-bottom-left-radius: 5px;
  border-bottom-right-radius: 5px;
  transition: all 0.3s ease-out;
  opacity: 0;
  z-index: 8;
}
.basket-content-check-select-input {
  display: none;
}
.basket-content-check-select-input:checked + .basket-content-check-select-input-label {
  background-color: #dedede;
}
.basket-content-check-select-input:disabled + .basket-content-check-select-input-label {
  opacity: 0.6;
  pointer-events: none;
}
.basket-content-check-select-label {
  color: #0B2239;
  font-size: 1.6rem;
  padding-bottom: 0.9rem;
  border-bottom: 1px solid #DAE3EA;
  padding-left: 2.1rem;
  padding-top: 0.8rem;
  transition: all 0.3s;
}
.basket-content-check-select-label:hover {
  color: #1CBFE0;
}
.basket-content-check-item {
  display: flex;
  align-items: center;
  position: relative;
  color: #0B2239;
  font-size: 1.6rem;
  padding-bottom: 0.7rem;
  border-bottom: 1px solid rgba(11, 34, 57, 0.2);
}
.basket-content-check-item:not(:last-child) {
  margin-bottom: 1rem;
}
.basket-content-check-item__active {
  font-weight: 600;
}
.basket-content-check-item-text {
  display: flex;
  align-items: center;
  justify-content: space-between;
  width: 100%;
}
.basket-content-check-item input {
  position: absolute;
  z-index: -1;
  opacity: 0;
}
.basket-content-check-item input + label {
  display: inline-flex;
  align-items: center;
  user-select: none;
  margin-right: 1.5rem;
}
.basket-content-check-item input + label::before {
  content: "";
  display: inline-block;
  width: 2rem;
  height: 2rem;
  flex-shrink: 0;
  flex-grow: 0;
  border: 2px solid #B6BDC4;
  border-radius: 0.5rem;
}
.basket-content-check-item input:checked + label::before {
  background: url(../icons/basket/check.svg) center center no-repeat, #0B2239;
  background-size: 1.2rem 1.2rem;
  border: none;
}
.basket-content-total {
  background: #EFF3F9;
  padding: 2.5rem 2.5rem 2.8rem 2.9rem;
}
.basket-content-total-price {
  color: #0B2239;
  font-size: 3.6rem;
  font-weight: 700;
  margin-bottom: 0.8rem;
}
.basket-content-total-text {
  display: flex;
  align-items: center;
  color: #85919C;
  font-size: 1.4rem;
  font-weight: 700;
}
.basket-content-total-text i {
  transform: rotate(30deg);
  margin-right: 0.7rem;
}
.basket-question {
  display: flex;
  align-items: center;
  justify-content: space-between;
}
.basket-question-title {
  color: #0B2239;
  font-size: 1.6rem;
}
.basket-question-title:nth-child(1) {
  font-size: 1.2rem;
}

.basket-modification .basket-content-text {
  margin-bottom: 2.1rem;
}

.noUi-base {
  background: #FFEBAD;
}
.noUi-target {
  height: 0.5rem;
  border: none;
  border-radius: 0.5rem;
}
.noUi-connect {
  background: #FFC924;
}
.noUi-handle {
  background: #FFC924;
  width: 1.7rem !important;
  height: 1.7rem !important;
  border-radius: 50%;
  box-shadow: none;
  border: none;
}
.noUi-handle::before, .noUi-handle::after {
  background: #FFEBAD;
  border-radius: 50%;
  width: 3.1rem;
  height: 3.1rem;
  left: -7px;
  top: -7px;
  z-index: -1;
}
.noUi-handle::before {
  left: 0;
  left: -7px;
  top: -7px;
}
.noUi-marker {
  display: none;
}
.noUi-value {
  color: #0B2239;
  font-size: 1.4rem;
  font-weight: 500;
}

.footer {
  background: #0B2239;
  padding: 9.1rem 19.2rem 2.2rem 19.5rem;
}
@media (max-width: 375px) {
  .footer {
    padding: 9.1rem 1.4rem 7.7rem 1.5rem;
    display: flex;
    flex-direction: column;
  }
}
.footer-top {
  display: flex;
  align-items: start;
  margin-bottom: 5.5rem;
}
@media (max-width: 375px) {
  .footer-top {
    flex-direction: column;
  }
}
@media (max-width: 375px) {
  .footer-list {
    margin-right: 0 !important;
    order: 3;
  }
}
.footer-list:nth-child(1) {
  margin-right: 37.7rem;
}
.footer-list:nth-child(2) {
  margin-right: 23.4rem;
}
.footer-list:nth-child(3) {
  margin-right: 19.1rem;
}
.footer-list-container {
  display: flex;
}
@media (max-width: 375px) {
  .footer-list-container {
    justify-content: space-between;
    width: 100%;
    margin-bottom: 5rem;
    order: 1;
  }
}
@media (max-width: 375px) {
  .footer-list-order {
    order: 2;
  }
}
.footer-list-items {
  display: flex;
  gap: 15rem;
}
@media (max-width: 375px) {
  .footer-list-items {
    gap: 4.9rem;
  }
}
.footer-list-item {
  font-size: 1.4rem;
  transition: all 0.3s;
  display: block;
  white-space: nowrap;
}
.footer-list-item:not(:last-child) {
  margin-bottom: 1rem;
}
.footer-list-item a {
  color: #fff;
}
.footer-list-item a:focus {
  outline: none;
}
.footer-list-item a:hover {
  color: #F36B25;
  text-decoration: none;
  cursor: pointer;
}
.footer-list-item a:active {
  color: #fff;
}
.footer-list-item__head {
  font-weight: 800;
  margin-bottom: 1.8rem;
}
@media (max-width: 375px) {
  .footer-social {
    order: 4;
  }
}
.footer-social-title {
  color: #fff;
  font-weight: 800;
  font-size: 1.4rem;
  margin-bottom: 1.8rem;
}
.footer-social-items {
  display: flex;
  align-items: center;
  gap: 1rem;
}
.footer-mid {
  display: flex;
  position: relative;
  margin-bottom: 10.6rem;
}
@media (max-width: 375px) {
  .footer-mid {
    flex-direction: column;
  }
}
.footer-mid::before {
  content: " ";
  width: 192rem;
  height: 1px;
  background: rgba(255, 255, 255, 0.15);
  position: absolute;
  bottom: -4.6rem;
  left: -19.5rem;
}
@media (max-width: 375px) {
  .footer-mid::before {
    width: 55.5rem;
    right: 0;
  }
}
.footer-payment {
  display: flex;
  flex-direction: column;
}
.footer-payment-icons {
  display: flex;
  align-items: center;
  margin-bottom: 5.1rem;
}
@media (max-width: 375px) {
  .footer-payment-icons {
    flex-wrap: wrap;
  }
}
.footer-payment-icons img:not(:last-child) {
  margin-right: 2.9rem;
}
.footer-rev {
  display: flex;
  align-items: center;
}
.footer-rev-text {
  color: #85919C;
  font-size: 1.6rem;
  line-height: 2.5rem;
}
.footer-rev img {
  width: 10.8rem;
  height: 2.5rem;
  margin-right: 1.3rem;
}
.footer-bottom {
  display: flex;
  justify-content: space-between;
}
@media (max-width: 375px) {
  .footer-bottom {
    flex-direction: column;
  }
}
.footer-bottom-text {
  width: 75rem;
  color: #85919C;
  font-style: 1.2rem;
  line-height: 2.1rem;
}
@media (max-width: 375px) {
  .footer-bottom-text {
    order: 2;
    width: 34.5rem;
  }
}
.footer-form {
  display: flex;
  align-items: center;
}
@media (max-width: 375px) {
  .footer-form {
    order: 1;
    flex-direction: column;
    align-items: start;
    margin-bottom: 4rem;
  }
}
.footer-form-container {
  display: flex;
}
.footer-form-title {
  width: 10rem;
  color: #fff;
  font-size: 1.4rem;
  font-weight: 800;
  margin-right: 3rem;
}
@media (max-width: 375px) {
  .footer-form-title {
    margin-bottom: 1.4rem;
    width: 100%;
  }
}
.footer-form-input {
  position: relative;
}
.footer-form-input input {
  background: none;
  border: 1px solid rgba(255, 255, 255, 0.3);
  background-size: 2rem 2rem;
  background-position-x: 2.1rem;
  margin-right: 1rem;
  font-size: 1.6rem;
  color: #fff;
  padding: 1.3rem 0 1.3rem 6.1rem;
  width: 36rem;
  border-radius: 0.5rem;
}
@media (max-width: 375px) {
  .footer-form-input input {
    width: 23.5rem;
    padding: 1.3rem 0.9rem 1.3rem 4.1rem;
    margin-right: 0.8rem;
  }
}
.footer-form-input input::placeholder {
  color: #fff;
  font-size: 1.6rem;
}
.footer-form-input input:focus {
  outline: none;
  border-color: #F36B25;
}
.footer-form-input label {
  width: 2rem;
  height: 2rem;
  position: absolute;
  left: 2rem;
  top: 1.5rem;
}

.header {
  display: flex;
  justify-content: space-between;
  align-items: center;
  background: #0B2239;
  padding: 1.3rem 3rem 1.4rem 5rem;
  color: #fff;
  border-bottom: 1px solid #2F4357;
  position: relative;
}
@media (max-width: 375px) {
  .header {
    padding: 0.8rem 1.5rem;
    width: 100%;
  }
}
.header-burger {
  position: absolute;
  top: 5rem;
  left: 0;
  display: none;
  padding: 3rem 4.4rem 8.7rem 5rem;
  width: 100%;
  background: #0B2239;
  z-index: 4;
}
.header-burger__active {
  display: flex;
  flex-direction: column;
}
.header-burger-title {
  color: #85919C;
  font-size: 1.4rem;
  font-weight: 600;
  margin-bottom: 1.9rem;
}
.header-burger-items {
  display: flex;
  flex-direction: column;
  gap: 1.4rem;
  margin-bottom: 3.6rem;
}
.header-burger-item {
  color: #85919C;
  font-size: 1.4rem;
  padding-bottom: 1.7rem;
  position: relative;
  transition: all 0.3s;
  white-space: nowrap;
}
.header-burger-item:hover {
  color: #F36B25;
  cursor: pointer;
  text-decoration: none;
}
.header-burger-item:active {
  color: #85919C;
}
.header-burger-item::after {
  content: " ";
  width: 37.5rem;
  height: 1px;
  background: #85919C;
  position: absolute;
  left: -5rem;
  top: 100%;
}
.header-burger-item i {
  margin-right: 1.4rem;
}
.header-burger-links {
  margin-bottom: 4rem;
  display: flex;
  flex-direction: column;
  gap: 2.5rem;
}
.header-burger-link {
  color: #85919C;
  font-size: 1.4rem;
  font-weight: 600;
}
.header-burger-select {
  background: none;
  border: none;
  color: #fff;
  font-size: 1.4rem;
  font-weight: 600;
  position: relative;
}
.header-burger-select:focus {
  outline: none;
}
.header-burger-select-container {
  position: relative;
  padding: 1.6rem 0 1.3rem 0;
}
.header-burger-select-container::before {
  content: " ";
  width: 37.5rem;
  height: 1px;
  background: #2F4357;
  position: absolute;
  left: -5rem;
  top: 0;
}
.header-burger-select-container::after {
  content: " ";
  width: 37.5rem;
  height: 1px;
  background: #2F4357;
  position: absolute;
  left: -5rem;
  top: 100%;
}
.header-burger-button {
  background: #2F4357;
  font-size: 1.4rem;
  border-radius: 0.5rem;
  width: 2.9rem;
  height: 2.9rem;
  align-items: center;
  justify-content: center;
  display: none;
  transition: all 0.3s;
  margin-right: 2rem;
  color: #fff;
  border: none;
}
.header-burger-button:focus {
  outline: none;
}
.header-burger-button:hover {
  color: #00B67A;
  cursor: pointer;
}
.header-burger-button:active {
  color: #fff;
}
@media (max-width: 375px) {
  .header-burger-button {
    display: flex;
  }
}
.header-burger-button__active {
  background: url(../icons/burger/close.svg) center center no-repeat, #2F4357;
  background-size: 1.3rem 1.3rem;
  padding: 0.8rem;
  transition: all 0.3s;
}
.header-burger-button__active i {
  display: none;
}
.header-left {
  display: flex;
  align-items: center;
}
.header-icon {
  margin-right: 24rem;
}
@media (max-width: 375px) {
  .header-icon {
    margin-right: 4.3rem;
  }
}
.header-select {
  position: relative;
}
@media (max-width: 375px) {
  .header-select {
    display: none;
  }
}
.header-devider {
  width: 6.9rem;
  height: 1px;
  background: #2F4357;
  transform: rotate(90deg);
  position: absolute;
}
.header-devider:nth-child(1) {
  top: 1rem;
  left: -8rem;
}
.header-devider:nth-child(3) {
  top: 1rem;
  right: -6rem;
}
.header-devider:nth-child(6) {
  right: 9.9rem;
  top: 3.5rem;
}
@media (max-width: 375px) {
  .header-devider {
    display: none;
  }
}
.header-games {
  position: relative;
  background: none;
  border: none;
  color: #fff;
  text-transform: uppercase;
  font-size: 1.4rem;
  font-weight: 600;
  transition: all 0.3s;
}
.header-games:focus {
  outline: none;
}
.header-games:hover {
  color: #00B67A;
}
.header-games:active {
  color: #fff;
}
.header-list {
  margin-left: 8rem;
  display: flex;
  align-items: center;
  list-style: none;
}
@media (max-width: 375px) {
  .header-list {
    display: none;
  }
}
.header-list-item:not(:last-child) {
  margin-right: 3.8rem;
}
.header-list-item a {
  color: #2F4357;
  font-size: 1.4rem;
  font-weight: 600;
  transition: all 0.3s;
  text-decoration: none;
}
.header-list-item a:hover {
  color: #fff;
}
.header-list-item a:active {
  color: #2F4357;
}
.header-actions {
  display: flex;
}
.header-actions-input {
  display: none;
}
@media (max-width: 375px) {
  .header-actions-input {
    background: url(../icons/header/search.svg) right center no-repeat, #3C4E61;
    background-size: 1.9rem 1.9rem;
    background-position-x: 32.6rem;
    border: none;
    color: #fff;
    width: 100%;
    height: 100%;
    font-size: 1.4rem;
    display: none;
    position: absolute;
    left: 0;
    top: 0;
    padding: 1rem 0 1rem 3rem;
  }
  .header-actions-input:focus {
    outline: none;
    border-color: #00B67A;
  }
  .header-actions-input::placeholder {
    color: #fff;
    font-size: 1.4rem;
  }
}
.header-payment {
  background: none;
  border: none;
  color: #fff;
  font-size: 1.4rem;
  font-weight: 600;
  transition: all 0.3s;
  text-transform: uppercase;
  margin-right: 4.2rem;
}
@media (max-width: 375px) {
  .header-payment {
    display: none;
  }
}
.header-payment:focus {
  outline: none;
}
.header-payment:hover {
  color: #00B67A;
}
.header-payment:active {
  color: #fff;
}

.hero {
  overflow: hidden;
  background: url(../img/hero/1.png), #0B2239 center center;
  background-repeat: no-repeat;
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 18.7rem 19.5rem 16.4rem 19.5rem;
  height: 71rem;
  margin-bottom: 8rem;
}
@media (max-width: 375px) {
  .hero {
    display: block;
    padding: 6.6rem 4.3rem;
    background: url(../img/hero/hero-bcg-mobile.png), #0B2239;
    background-position-y: bottom;
    background-position-x: center;
    background-repeat: no-repeat;
    height: 60rem;
    margin-bottom: 5rem;
  }
}
@media (max-width: 375px) {
  .hero-rating-icon {
    width: 15rem;
    height: 3.5rem;
  }
}
.hero-rating-stars {
  display: flex;
}

.choose-game {
  margin-bottom: 9rem;
}
@media (max-width: 375px) {
  .choose-game {
    margin-bottom: 7rem;
  }
}
.choose-game-items {
  display: flex;
  justify-content: space-between;
  flex-wrap: wrap;
}
@media (max-width: 375px) {
  .choose-game-items {
    display: grid;
    grid-template-columns: repeat(2, 1fr);
    gap: 1.5rem;
  }
}

.how-works-items {
  display: flex;
}
@media (max-width: 375px) {
  .how-works-items {
    overflow-x: auto;
  }
  .how-works-items::-webkit-scrollbar {
    display: none;
  }
}

.why {
  padding: 0 30.4rem 0 34.5rem;
}
@media (max-width: 375px) {
  .why {
    padding: 0 3rem 0 2.5rem;
  }
}
.why-items {
  gap: 15.5rem 5.5rem;
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
}
@media (max-width: 375px) {
  .why-items {
    gap: 0;
  }
}

.reviews {
  padding: 0 14.7rem 0 13.3rem;
  margin-bottom: 10.9rem;
}
@media (max-width: 375px) {
  .reviews {
    padding: 0;
    margin-bottom: 9rem;
  }
}
.reviews-subtitle {
  color: #0B2239;
  font-size: 1.6rem;
  line-height: 2.6rem;
  margin-right: 0.3rem;
}
.reviews-text {
  display: flex;
  align-items: end;
  padding-left: 6.2rem;
  margin-bottom: 2.8rem;
}
@media (max-width: 375px) {
  .reviews-text {
    display: block;
    text-align: center;
    padding: 0;
  }
}
.reviews-comments {
  display: flex;
  align-items: center;
  gap: 3rem;
}
@media (max-width: 375px) {
  .reviews-comments {
    overflow-x: auto;
  }
  .reviews-comments::-webkit-scrollbar {
    display: none;
  }
}

.faq-content {
  display: flex;
  justify-content: space-between;
}
@media (max-width: 375px) {
  .faq-content {
    display: block;
  }
}
.faq-questions {
  display: flex;
  flex-direction: column;
  gap: 2rem;
}

.blog {
  padding: 0 14.7rem;
}
@media (max-width: 375px) {
  .blog {
    padding: 0 0 0 1.5rem;
  }
}
.blog-text {
  padding-left: 4.8rem;
}
@media (max-width: 375px) {
  .blog-text {
    padding-left: 0;
  }
}
.blog-cards {
  display: flex;
  flex-wrap: wrap;
  gap: 3rem;
  margin-bottom: 3.9rem;
}
@media (max-width: 375px) {
  .blog-cards {
    flex-wrap: nowrap;
    overflow-x: auto;
  }
  .blog-cards::-webkit-scrollbar {
    display: none;
  }
}

.modal-container {
  background: url(../img/modal/bcg.png) center center no-repeat;
  width: 100%;
  padding: 8rem 0 8.4rem 13.7rem;
  border-radius: 1rem;
}
@media (max-width: 375px) {
  .modal-container {
    background: url(../img/modal/bcg-mobile.png);
    padding: 5rem 3rem 6.3rem 3rem;
  }
}
.modal-title {
  color: #fff;
  margin-bottom: 2.2rem;
  text-transform: uppercase;
}
@media (max-width: 375px) {
  .modal-title {
    font-size: 3rem;
  }
}
.modal-title span {
  color: #FFC924;
}
.modal-descr {
  color: #fff;
  font-size: 1.8rem;
  line-height: 2.8rem;
  margin-bottom: 2.8rem;
}
@media (max-width: 375px) {
  .modal-descr {
    font-size: 1.6rem;
  }
}

.payment-items {
  display: flex;
  gap: 2rem;
}
@media (max-width: 375px) {
  .payment-items {
    overflow-x: auto;
  }
  .payment-items::-webkit-scrollbar {
    display: none;
  }
}
.payment-item {
  background: #3C4E61;
  min-width: 15.2rem;
  min-height: 8.5rem;
  display: flex;
  justify-content: center;
  align-items: center;
  border-radius: 0.7rem;
}

.card-info {
  background: url(../img/card-info/1.png);
  background-repeat: no-repeat;
  background-position-y: -8rem;
  padding: 3.8rem 0 0 19.5rem;
  width: 100%;
}
@media (max-width: 375px) {
  .card-info {
    padding: 0 1.5rem;
  }
}
.card-info-text {
  margin-bottom: 3.8rem;
}
.card-info-text-rating {
  display: flex;
  align-items: center;
  color: #0B2239;
  font-size: 1.6rem;
}
@media (max-width: 375px) {
  .card-info-text-rating {
    display: block;
    margin-bottom: 157.4rem;
  }
}
.card-info-text-rating-icons {
  display: flex;
  align-items: center;
}
.card-info-text-rating span {
  font-weight: 700;
}
.card-info-text-rating-stars {
  display: flex;
  align-items: center;
  gap: 0.4rem;
  margin-left: 0.8rem;
  margin-right: 0.9rem;
}
.card-info-text-rating-stars div {
  padding: 0.6rem;
  border-radius: 0.7rem;
  margin-right: 0 !important;
}
.card-info-text-rating-stars div img {
  width: 1.2rem;
  height: 1.2rem;
}
.card-info-content {
  width: 88.2rem;
}
@media (max-width: 375px) {
  .card-info-content {
    width: 34.5rem;
  }
}
.card-info-content-descr {
  margin-bottom: 12.2rem;
}
.card-info-content-descr-text {
  color: #0B2239;
  font-size: 1.6rem;
  margin-bottom: 1.8rem;
}
@media (max-width: 375px) {
  .card-info-content-descr-text {
    width: 34.5rem;
    margin-bottom: 2.9rem;
  }
}
.card-info-ul:not(:last-child) {
  margin-bottom: 3.3rem;
}
@media (max-width: 375px) {
  .card-info-ul:not(:last-child):not(:last-child) {
    margin-bottom: 2.3rem !important;
  }
}
.card-info-list {
  padding-left: 2em;
  list-style-image: url(../icons/card-info-list/skull.svg);
}
.card-info-list__done {
  list-style-image: url(../icons/card-info-list/check.svg);
}
.card-info-list__grey {
  list-style-image: url(../icons/card-info-list/mark.svg);
}
.card-info-list-item {
  font-size: 1.6rem;
  padding-left: 1.7rem;
}
@media (max-width: 375px) {
  .card-info-list-item {
    width: 32.8rem;
  }
}
.card-info-list-item a {
  color: #1CBFE0;
  text-decoration: underline;
  transition: all 0.3s;
}
.card-info-list-item a:hover {
  cursor: pointer;
  text-decoration: none;
  color: #0B2239;
}
.card-info-list-item a:active {
  color: #1CBFE0;
}
.card-info-list-item:not(:last-child) {
  margin-bottom: 1.5rem;
}

@media (max-width: 375px) {
  .card-info-text > .title-secondary {
    font-size: 3.6rem;
    margin-bottom: 1.3rem;
  }
}

.also-cards {
  overflow-x: auto;
  overflow-y: hidden;
  width: 131.5rem;
  gap: 0;
}
.also-cards::-webkit-scrollbar {
  display: none;
}
@media (max-width: 375px) {
  .also-cards {
    width: 34.5rem;
  }
}
.also-cards-button {
  position: absolute;
  right: 13rem;
}
.also-cards-button__first {
  position: absolute;
  left: 38rem;
}

.also .game-card:not(:last-child) {
  margin-right: 3rem;
}

.card-reviews .comment {
  width: 40.4rem;
}

.card-how-works {
  padding: 0;
  padding-right: 19.5rem;
}
@media (max-width: 375px) {
  .card-how-works {
    padding-right: 0;
  }
}

.card-why {
  padding: 0;
  padding-right: 19.5rem;
}
@media (max-width: 375px) {
  .card-why {
    padding-right: 0;
  }
}

/*# sourceMappingURL=style.cs.map */
